using System;
using System.Collections.Generic;
using static PostgresqlUtility.Services.PsqlQuery;

namespace PostgresqlUtility.Services;

public sealed class PsqlArgumentsBuilder
{
    private PsqlOptions _options = PsqlOptions.Default;
    private string _host;
    private int? _port;
    private string _user;
    private string _database;
    private string _command; // inline SQL (-c)
    private string _file;    // SQL file path (-f)

    private static string Quote(string s) =>
        (s ?? "").IndexOf(' ') >= 0
            ? $"\"{s.Replace("\"", "\\\"")}\""
            : s;

    public static PsqlArgumentsBuilder Create() => new PsqlArgumentsBuilder();

    public PsqlArgumentsBuilder WithOptions(PsqlOptions options)
    {
        _options = options ?? PsqlOptions.Default;
        return this;
    }

    public PsqlArgumentsBuilder WithHost(string host)
    {
        _host = host;
        return this;
    }

    public PsqlArgumentsBuilder WithPort(int port)
    {
        _port = port;
        return this;
    }

    public PsqlArgumentsBuilder WithUser(string user)
    {
        _user = user;
        return this;
    }

    public PsqlArgumentsBuilder WithDatabase(string database)
    {
        _database = database;
        return this;
    }

    /// <summary>
    /// Supply an inline SQL command via -c. Mutually exclusive with WithFile().
    /// </summary>
    public PsqlArgumentsBuilder WithCommand(string sql)
    {
        if (string.IsNullOrWhiteSpace(sql))
            throw new ArgumentException("SQL command cannot be null or empty.", nameof(sql));

        // Trim whitespace and ensure trailing semicolon
        var trimmed = sql.TrimEnd();
        if (!trimmed.EndsWith(';'))
        {
            trimmed += ";";
        }

        _command = trimmed;
        _file = null; // clear any previously set file
        return this;
    }

    /// <summary>
    /// Supply a path to a SQL script file via -f. Mutually exclusive with WithCommand().
    /// </summary>
    public PsqlArgumentsBuilder WithFile(string pathToFile)
    {
        _file = pathToFile;
        _command = null; // clear command if previously set
        return this;
    }

    public string Build()
    {
        // Validate that exactly one of command/file is set:
        if (string.IsNullOrEmpty(_command) && string.IsNullOrEmpty(_file))
            throw new InvalidOperationException("Either an inline SQL command or a SQL file path must be specified.");
        if (!string.IsNullOrEmpty(_command) && !string.IsNullOrEmpty(_file))
            throw new InvalidOperationException("Cannot specify both inline SQL command and SQL file path.");

        var parts = new List<string>();

        if (!string.IsNullOrEmpty(_host))
            parts.Add($"-h {Quote(_host)}");

        if (_port.HasValue)
            parts.Add($"-p {_port.Value}");

        if (!string.IsNullOrEmpty(_user))
            parts.Add($"-U {Quote(_user)}");

        if (!string.IsNullOrEmpty(_database))
            parts.Add($"-d {Quote(_database)}");

        if (!_options.ShowColumnName)
            parts.Add("-t");

        // exactly one of these will run:
        if (!string.IsNullOrEmpty(_command))
            parts.Add($"-c {Quote(_command)}");
        else
            parts.Add($"-f {Quote(_file)}");

        return string.Join(" ", parts);
    }
}

using PostgresqlUtility.Connection;
using PostgresqlUtility.Domain;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace PostgresqlUtility.Services;

public sealed class PsqlQuery
{
    public sealed class PsqlOptions
    {
        public bool ShowColumnName { get; set; } = true;

        public static PsqlOptions Default => new();
    }

    private readonly PostgresqlConnectionContext context;
    private readonly PsqlOptions options;

    public PsqlQuery(PostgresqlConnectionContext context) : this(context, PsqlOptions.Default)
    {

    }

    public PsqlQuery(PostgresqlConnectionContext context, PsqlOptions options)
    {
        this.context = context;
        this.options = options;
    }

    public async Task<string> ExecuteQueryAsync(string pgBinPath, string query, CancellationToken token = default)
    {
        var inlineArgs = PsqlArgumentsBuilder.Create()
            .WithOptions(options) // tuples-only
            .WithHost(context.Host)
            .WithPort(context.Port)
            .WithUser(context.DatabaseUser)
            .WithDatabase(context.DatabaseName)
            .WithCommand(query)
            .Build();

        var psi = new ProcessStartInfo
        {
            FileName = Path.Combine(pgBinPath, "psql.exe"),
            Arguments = inlineArgs,
        };
        psi.EnvironmentVariables["PGPASSWORD"] = context.DatabasePassword;

        var shell = new ShellExecutor(psi);
        var (stdOut, stdErr) = await shell.RunAsync(token);

        if (!string.IsNullOrEmpty(stdErr))
            throw new PostgresqlUtilityException($"Error executing query: {stdErr}");

        return stdOut;
    }

    public async Task<string> ExecuteSqlFileAsync(string pgBinPath, string file, CancellationToken token)
    {
        var fileArgs = PsqlArgumentsBuilder.Create()
            .WithOptions(options)
            .WithHost(context.Host)
            .WithPort(context.Port)
            .WithUser(context.DatabaseUser)
            .WithDatabase(context.DatabaseName)
            .WithFile(file)
            .Build();

        var psi = new ProcessStartInfo
        {
            FileName = Path.Combine(pgBinPath, "psql.exe"),
            Arguments = fileArgs,
        };
        psi.EnvironmentVariables["PGPASSWORD"] = context.DatabasePassword;

        var shell = new ShellExecutor(psi);
        var (stdOut, stdErr) = await shell.RunAsync(token);

        if (!string.IsNullOrEmpty(stdErr))
            throw new PostgresqlUtilityException($"Error executing query: {stdErr}");

        return stdOut;
    }

    public const string QueryGetAllDatabaseName = "SELECT datname FROM pg_database WHERE datistemplate = false;";
}

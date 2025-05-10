using PostgresqlUtility.Connection;
using PostgresqlUtility.Domain;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace PostgresqlUtility.Services;

public sealed class PsqlQuery
{
    private readonly PostgresqlConnectionContext context;

    public PsqlQuery(PostgresqlConnectionContext context)
    {
        this.context = context;
    }

    public async Task<string> ExecuteQueryAsync(string pgBinPath, string query, CancellationToken token = default)
    {
        var psi = new ProcessStartInfo
        {
            FileName = Path.Combine(pgBinPath, "psql.exe"),
            Arguments = $"-h {context.Host} -p {context.Port} -U {context.DatabaseUser} -d {context.DatabaseName} -t -c \"{query}\"",
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

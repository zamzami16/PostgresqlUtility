using PostgresqlUtility.Connection;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace PostgresqlUtility.Services;

public sealed class BackupDatabase
{
    private readonly PostgresqlConnectionContext context;

    public BackupDatabase(PostgresqlConnectionContext context)
    {
        this.context = context;
    }

    public async Task BackupAsync(string pgDumpPath, string dbName, string outputPath, CancellationToken token = default)
    {
        var psi = new ProcessStartInfo
        {
            FileName = Path.Combine(pgDumpPath, "pg_dump.exe"),
            Arguments = $"-h {context.Host} -p {context.Port} -U {context.DatabaseUser} -Fc -b -f \"{outputPath}\" \"{dbName}\"",
        };
        psi.EnvironmentVariables["PGPASSWORD"] = context.DatabasePassword;

        var shell = new ShellExecutor(psi);
        await shell.RunAsync(token);
    }
}

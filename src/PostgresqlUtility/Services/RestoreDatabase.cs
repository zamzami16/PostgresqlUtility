using PostgresqlUtility.Connection;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace PostgresqlUtility.Services;

public sealed class RestoreDatabase
{
    private readonly PostgresqlConnectionContext context;
    public RestoreDatabase(PostgresqlConnectionContext context)
    {
        this.context = context;
    }

    public async Task RestoreAsync(string pgBinPath, string inputPath, string dbName, CancellationToken token = default)
    {
        await RecreateDatabaseAsync(pgBinPath, dbName, token);

        var psi = new ProcessStartInfo
        {
            FileName = Path.Combine(pgBinPath, "pg_restore.exe"),
            Arguments = $"-h {context.Host} -p {context.Port} -U {context.DatabaseUser} -d \"{dbName}\" \"{inputPath}\"",
        };
        psi.EnvironmentVariables["PGPASSWORD"] = context.DatabasePassword;

        var shell = new ShellExecutor(psi);
        await shell.RunAsync(token);
    }

    public async Task RecreateDatabaseAsync(string pgBinPath, string dbName, CancellationToken token)
    {
        await DropDatabaseAsync(pgBinPath, dbName, token);
        await CreateDatabaseAsync(pgBinPath, dbName, token);
    }

    public async Task DropDatabaseAsync(string pgBinPath, string dbName, CancellationToken token)
    {
        var psi = new ProcessStartInfo
        {
            FileName = Path.Combine(pgBinPath, "psql.exe"),
            Arguments = $"-h {context.Host} -p {context.Port} -U {context.DatabaseUser} -d {context.DatabaseName} -c \"DROP DATABASE IF EXISTS \\\"{dbName}\\\";\"",
        };

        psi.EnvironmentVariables["PGPASSWORD"] = context.DatabasePassword;
        var shell = new ShellExecutor(psi);

        await shell.RunAsync(token);
    }

    public async Task CreateDatabaseAsync(string pgBinPath, string dbName, CancellationToken token)
    {
        var psi = new ProcessStartInfo
        {
            FileName = Path.Combine(pgBinPath, "psql.exe"),
            Arguments = $"-h {context.Host} -p {context.Port} -U {context.DatabaseUser} -d {context.DatabaseName} -c \"CREATE DATABASE \\\"{dbName}\\\" template template0;\"",
        };

        psi.EnvironmentVariables["PGPASSWORD"] = context.DatabasePassword;
        var shell = new ShellExecutor(psi);

        await shell.RunAsync(token);
    }
}

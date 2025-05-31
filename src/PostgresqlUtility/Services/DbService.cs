using PostgresqlUtility.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresqlUtility.Services;

public sealed class DbService(string binPath, PostgresqlConnectionContext context)
{
    public async Task<IEnumerable<string>> GetAllDatabaseNameAsync()
    {
        var psqlQuery = new PsqlQuery(context, new PsqlQuery.PsqlOptions { ShowColumnName = false });
        var query = PsqlQuery.QueryGetAllDatabaseName;

        var result = await psqlQuery.ExecuteQueryAsync(binPath, query);

        return result.Split([Environment.NewLine], StringSplitOptions.RemoveEmptyEntries)
                     .Select(db => db.Trim())
                     .Where(db => !string.IsNullOrWhiteSpace(db));
    }

    public static async Task<bool> TestConnectionAsync(string binPath, PostgresqlConnectionContext context)
    {
        var psqlQuery = new PsqlQuery(context);
        var query = "SELECT 1;";

        try
        {
            await psqlQuery.ExecuteQueryAsync(binPath, query);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}

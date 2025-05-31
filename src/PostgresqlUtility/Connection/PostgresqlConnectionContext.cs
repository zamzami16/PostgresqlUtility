namespace PostgresqlUtility.Connection;

public sealed class PostgresqlConnectionContext
{
    public string Host { get; set; } = "localhost";
    public int Port { get; set; } = 5432;
    public string DatabaseName { get; set; } = "postgres";
    public string DatabasePassword { get; set; } = "postgres";
    public string DatabaseUser { get; set; } = "postgres";
}

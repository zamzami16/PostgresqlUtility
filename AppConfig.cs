using PostgresqlUtility.Connection;
using System;
using System.IO;
using System.Text.Json;

namespace PostgresqlUtility;

public sealed class AppConfig
{
    public PostgresqlConnectionContext PostgresqlConnectionContext { get; set; }
    public string PostgresqlBinPath { get; set; } = string.Empty;

    private const string ConfigName = "AppConfig.json";
    private static readonly Lazy<AppConfig> instance = new(() =>
    {
        AppConfig config = default;

        if (File.Exists(ConfigName))
        {
            var file = File.ReadAllText(ConfigName);
            config = JsonSerializer.Deserialize<AppConfig>(file) ?? new AppConfig();
            return config;
        }

        config = new AppConfig
        {
            PostgresqlConnectionContext = new PostgresqlConnectionContext(),
        };

        var configStr = JsonSerializer.Serialize(config);
        File.WriteAllText(ConfigName, configStr);

        return config;
    });

    public static AppConfig Instance => instance.Value;

    public void Save()
    {
        var configStr = JsonSerializer.Serialize(this);
        File.WriteAllText(ConfigName, configStr);
    }
}

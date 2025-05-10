using System;
using System.Diagnostics.CodeAnalysis;

namespace PostgresqlUtility.Domain;

[ExcludeFromCodeCoverage]
public class PostgresqlUtilityException : Exception
{
    public PostgresqlUtilityException(string message) : base(message)
    {
    }
    public PostgresqlUtilityException(string message, Exception innerException) : base(message, innerException)
    {
    }
}

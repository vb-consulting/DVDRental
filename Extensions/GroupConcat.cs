#pragma warning disable CS8632
// pgroutiner auto-generated code
using System.Threading.Tasks;
using NpgsqlTypes;
using Npgsql;

namespace dvdrental.Extensions;

public static class PgRoutineGroupConcat
{
    public const string Name = "public._group_concat";
    public const string Query = $"select {Name}($1, $2)";

    /// <summary>
    /// Executes sql function public._group_concat(text, text)
    /// </summary>
    /// <param name="param1">param1 text</param>
    /// <param name="param2">param2 text</param>
    /// <returns>string?</returns>
    public static string? GroupConcat(this NpgsqlConnection connection, string? param1, string? param2)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Text, Value = param1 == null ? DBNull.Value : param1 },
                new() { NpgsqlDbType = NpgsqlDbType.Text, Value = param2 == null ? DBNull.Value : param2 }
            },
            AllResultTypesAreUnknown = true
        };
        if (connection.State != System.Data.ConnectionState.Open)
        {
            connection.Open();
        }
        using var reader = command.ExecuteReader(System.Data.CommandBehavior.SingleResult);
        if (reader.Read())
        {
            var value = reader.GetProviderSpecificValue(0);
            return value == DBNull.Value ? null : (string)value;
        }
        return default;
    }

    /// <summary>
    /// Asynchronously executes sql function public._group_concat(text, text)
    /// </summary>
    /// <param name="param1">param1 text</param>
    /// <param name="param2">param2 text</param>
    /// <returns>Task whose Result property is string?</returns>
    public static async Task<string?> GroupConcatAsync(this NpgsqlConnection connection, string? param1, string? param2)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Text, Value = param1 == null ? DBNull.Value : param1 },
                new() { NpgsqlDbType = NpgsqlDbType.Text, Value = param2 == null ? DBNull.Value : param2 }
            },
            AllResultTypesAreUnknown = true
        };
        if (connection.State != System.Data.ConnectionState.Open)
        {
            await connection.OpenAsync();
        }
        using var reader = await command.ExecuteReaderAsync(System.Data.CommandBehavior.SingleResult);
        if (await reader.ReadAsync())
        {
            var value = reader.GetProviderSpecificValue(0);
            return value == DBNull.Value ? null : (string)value;
        }
        return default;
    }
}

#pragma warning disable CS8632
// pgroutiner auto-generated code
using System.Threading.Tasks;
using NpgsqlTypes;
using Npgsql;

namespace dvdrental.Extensions;

public static class PgRoutineLastDay
{
    public const string Name = "public.last_day";
    public const string Query = $"select {Name}($1)";

    /// <summary>
    /// Executes sql function public.last_day(timestamp without time zone)
    /// </summary>
    /// <param name="param1">param1 timestamp without time zone</param>
    /// <returns>DateTime?</returns>
    public static DateTime? LastDay(this NpgsqlConnection connection, DateTime? param1)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Timestamp, Value = param1 == null ? DBNull.Value : param1 }
            },
        };
        if (connection.State != System.Data.ConnectionState.Open)
        {
            connection.Open();
        }
        using var reader = command.ExecuteReader(System.Data.CommandBehavior.SingleResult);
        if (reader.Read())
        {
            var value = reader.GetProviderSpecificValue(0);
            return value == DBNull.Value ? null : (DateTime)value;
        }
        return default;
    }

    /// <summary>
    /// Asynchronously executes sql function public.last_day(timestamp without time zone)
    /// </summary>
    /// <param name="param1">param1 timestamp without time zone</param>
    /// <returns>Task whose Result property is DateTime?</returns>
    public static async Task<DateTime?> LastDayAsync(this NpgsqlConnection connection, DateTime? param1)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Timestamp, Value = param1 == null ? DBNull.Value : param1 }
            },
        };
        if (connection.State != System.Data.ConnectionState.Open)
        {
            await connection.OpenAsync();
        }
        using var reader = await command.ExecuteReaderAsync(System.Data.CommandBehavior.SingleResult);
        if (await reader.ReadAsync())
        {
            var value = reader.GetProviderSpecificValue(0);
            return value == DBNull.Value ? null : (DateTime)value;
        }
        return default;
    }
}

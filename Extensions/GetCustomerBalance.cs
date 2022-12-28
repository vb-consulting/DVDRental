#pragma warning disable CS8632
// pgroutiner auto-generated code
using System.Threading.Tasks;
using NpgsqlTypes;
using Npgsql;

namespace dvdrental.Extensions;

public static class PgRoutineGetCustomerBalance
{
    public const string Name = "public.get_customer_balance";
    public const string Query = $"select {Name}($1, $2)";

    /// <summary>
    /// Executes plpgsql function public.get_customer_balance(integer, timestamp without time zone)
    /// </summary>
    /// <param name="pCustomerId">p_customer_id integer</param>
    /// <param name="pEffectiveDate">p_effective_date timestamp without time zone</param>
    /// <returns>decimal?</returns>
    public static decimal? GetCustomerBalance(this NpgsqlConnection connection, int? pCustomerId, DateTime? pEffectiveDate)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Integer, Value = pCustomerId == null ? DBNull.Value : pCustomerId },
                new() { NpgsqlDbType = NpgsqlDbType.Timestamp, Value = pEffectiveDate == null ? DBNull.Value : pEffectiveDate }
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
            return value == DBNull.Value ? null : (decimal)value;
        }
        return default;
    }

    /// <summary>
    /// Asynchronously executes plpgsql function public.get_customer_balance(integer, timestamp without time zone)
    /// </summary>
    /// <param name="pCustomerId">p_customer_id integer</param>
    /// <param name="pEffectiveDate">p_effective_date timestamp without time zone</param>
    /// <returns>Task whose Result property is decimal?</returns>
    public static async Task<decimal?> GetCustomerBalanceAsync(this NpgsqlConnection connection, int? pCustomerId, DateTime? pEffectiveDate)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Integer, Value = pCustomerId == null ? DBNull.Value : pCustomerId },
                new() { NpgsqlDbType = NpgsqlDbType.Timestamp, Value = pEffectiveDate == null ? DBNull.Value : pEffectiveDate }
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
            return value == DBNull.Value ? null : (decimal)value;
        }
        return default;
    }
}

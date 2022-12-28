#pragma warning disable CS8632
// pgroutiner auto-generated code
using System.Threading.Tasks;
using NpgsqlTypes;
using Npgsql;

namespace dvdrental.Extensions;

public static class PgRoutineInventoryHeldByCustomer
{
    public const string Name = "public.inventory_held_by_customer";
    public const string Query = $"select {Name}($1)";

    /// <summary>
    /// Executes plpgsql function public.inventory_held_by_customer(integer)
    /// </summary>
    /// <param name="pInventoryId">p_inventory_id integer</param>
    /// <returns>int?</returns>
    public static int? InventoryHeldByCustomer(this NpgsqlConnection connection, int? pInventoryId)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Integer, Value = pInventoryId == null ? DBNull.Value : pInventoryId }
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
            return value == DBNull.Value ? null : (int)value;
        }
        return default;
    }

    /// <summary>
    /// Asynchronously executes plpgsql function public.inventory_held_by_customer(integer)
    /// </summary>
    /// <param name="pInventoryId">p_inventory_id integer</param>
    /// <returns>Task whose Result property is int?</returns>
    public static async Task<int?> InventoryHeldByCustomerAsync(this NpgsqlConnection connection, int? pInventoryId)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Integer, Value = pInventoryId == null ? DBNull.Value : pInventoryId }
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
            return value == DBNull.Value ? null : (int)value;
        }
        return default;
    }
}

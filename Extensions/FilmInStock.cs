#pragma warning disable CS8632
// pgroutiner auto-generated code
using System.Threading.Tasks;
using NpgsqlTypes;
using Npgsql;

namespace dvdrental.Extensions;

public static class PgRoutineFilmInStock
{
    public const string Name = "public.film_in_stock";
    public const string Query = $"select p_film_count from {Name}($1, $2)";

    /// <summary>
    /// Executes sql function public.film_in_stock(integer, integer)
    /// </summary>
    /// <param name="pFilmId">p_film_id integer</param>
    /// <param name="pStoreId">p_store_id integer</param>
    /// <returns>IEnumerable of int? instances</returns>
    public static IEnumerable<int?> FilmInStock(this NpgsqlConnection connection, int? pFilmId, int? pStoreId)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Integer, Value = pFilmId == null ? DBNull.Value : pFilmId },
                new() { NpgsqlDbType = NpgsqlDbType.Integer, Value = pStoreId == null ? DBNull.Value : pStoreId }
            },
            UnknownResultTypeList = new bool[] { false }
        };
        if (connection.State != System.Data.ConnectionState.Open)
        {
            connection.Open();
        }
        using var reader = command.ExecuteReader(System.Data.CommandBehavior.Default);
        while (reader.Read())
        {
            var value = reader.GetProviderSpecificValue(0);
            yield return value == DBNull.Value ? null : (int)value;
        }
    }

    /// <summary>
    /// Asynchronously executes sql function public.film_in_stock(integer, integer)
    /// </summary>
    /// <param name="pFilmId">p_film_id integer</param>
    /// <param name="pStoreId">p_store_id integer</param>
    /// <returns>IAsyncEnumerable of int? instances</returns>
    public static async IAsyncEnumerable<int?> FilmInStockAsync(this NpgsqlConnection connection, int? pFilmId, int? pStoreId)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Integer, Value = pFilmId == null ? DBNull.Value : pFilmId },
                new() { NpgsqlDbType = NpgsqlDbType.Integer, Value = pStoreId == null ? DBNull.Value : pStoreId }
            },
            UnknownResultTypeList = new bool[] { false }
        };
        if (connection.State != System.Data.ConnectionState.Open)
        {
            await connection.OpenAsync();
        }
        using var reader = await command.ExecuteReaderAsync(System.Data.CommandBehavior.Default);
        while (await reader.ReadAsync())
        {
            var value = reader.GetProviderSpecificValue(0);
            yield return value == DBNull.Value ? null : (int)value;
        }
    }
}

#pragma warning disable CS8632
// pgroutiner auto-generated code
using System.Threading.Tasks;
using NpgsqlTypes;
using Npgsql;
using dvdrental.Models;

namespace dvdrental.Extensions;

public static class PgRoutineRewardsReport
{
    public const string Name = "public.rewards_report";
    public const string Query = $"select customer_id, store_id, first_name, last_name, email, address_id, activebool, create_date, last_update, active from {Name}($1, $2)";

    /// <summary>
    /// Executes plpgsql function public.rewards_report(integer, numeric)
    /// </summary>
    /// <param name="minMonthlyPurchases">min_monthly_purchases integer</param>
    /// <param name="minDollarAmountPurchased">min_dollar_amount_purchased numeric</param>
    /// <returns>IEnumerable of Customer instances</returns>
    public static IEnumerable<Customer> RewardsReport(this NpgsqlConnection connection, int? minMonthlyPurchases, decimal? minDollarAmountPurchased)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Integer, Value = minMonthlyPurchases == null ? DBNull.Value : minMonthlyPurchases },
                new() { NpgsqlDbType = NpgsqlDbType.Numeric, Value = minDollarAmountPurchased == null ? DBNull.Value : minDollarAmountPurchased }
            },
            UnknownResultTypeList = new bool[] { false, false, true, true, true, false, false, false, false, false }
        };
        if (connection.State != System.Data.ConnectionState.Open)
        {
            connection.Open();
        }
        using var reader = command.ExecuteReader(System.Data.CommandBehavior.Default);
        while (reader.Read())
        {
            object[] values = new object[10];
            reader.GetProviderSpecificValues(values);
            yield return new Customer
            {
                CustomerId = (int)values[0],
                StoreId = (short)values[1],
                FirstName = (string)values[2],
                LastName = (string)values[3],
                Email = values[4] == DBNull.Value ? null : (string)values[4],
                AddressId = (short)values[5],
                Activebool = (bool)values[6],
                CreateDate = (DateTime)values[7],
                LastUpdate = values[8] == DBNull.Value ? null : (DateTime)values[8],
                Active = values[9] == DBNull.Value ? null : (int)values[9]
            };
        }
    }

    /// <summary>
    /// Asynchronously executes plpgsql function public.rewards_report(integer, numeric)
    /// </summary>
    /// <param name="minMonthlyPurchases">min_monthly_purchases integer</param>
    /// <param name="minDollarAmountPurchased">min_dollar_amount_purchased numeric</param>
    /// <returns>IAsyncEnumerable of Customer instances</returns>
    public static async IAsyncEnumerable<Customer> RewardsReportAsync(this NpgsqlConnection connection, int? minMonthlyPurchases, decimal? minDollarAmountPurchased)
    {
        using var command = new NpgsqlCommand(Query, connection)
        {
            CommandType = System.Data.CommandType.Text,
            Parameters =
            {
                new() { NpgsqlDbType = NpgsqlDbType.Integer, Value = minMonthlyPurchases == null ? DBNull.Value : minMonthlyPurchases },
                new() { NpgsqlDbType = NpgsqlDbType.Numeric, Value = minDollarAmountPurchased == null ? DBNull.Value : minDollarAmountPurchased }
            },
            UnknownResultTypeList = new bool[] { false, false, true, true, true, false, false, false, false, false }
        };
        if (connection.State != System.Data.ConnectionState.Open)
        {
            await connection.OpenAsync();
        }
        using var reader = await command.ExecuteReaderAsync(System.Data.CommandBehavior.Default);
        while (await reader.ReadAsync())
        {
            object[] values = new object[10];
            reader.GetProviderSpecificValues(values);
            yield return new Customer
            {
                CustomerId = (int)values[0],
                StoreId = (short)values[1],
                FirstName = (string)values[2],
                LastName = (string)values[3],
                Email = values[4] == DBNull.Value ? null : (string)values[4],
                AddressId = (short)values[5],
                Activebool = (bool)values[6],
                CreateDate = (DateTime)values[7],
                LastUpdate = values[8] == DBNull.Value ? null : (DateTime)values[8],
                Active = values[9] == DBNull.Value ? null : (int)values[9]
            };
        }
    }
}

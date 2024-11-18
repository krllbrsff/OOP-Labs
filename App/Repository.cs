using System.Collections.ObjectModel;
using Domain.Models;
using Domain.Ports;
using Migrations;
using Npgsql;
namespace App;

public class Repository : IRepository
{
    public Collection<Transaction> GetAllTransactions(int id)
    {
        using NpgsqlConnection connection = DBConnect.Connection();
        using var command = new NpgsqlCommand();
        command.Connection = connection;
        command.CommandText = "select * from transactions where id = @id;";
        command.Parameters.AddWithValue("@id", id);
        connection.Open();

        NpgsqlDataReader reader = command.ExecuteReader();

        var transactions = new Collection<Transaction>();

        while (reader.Read())
        {
            var transaction = new Transaction(reader.GetInt32(3), reader.GetDecimal(1));
            transactions.Add(transaction);
        }

        return transactions;
    }

    public void HandleTransaction(Transaction transaction)
    {
        ArgumentNullException.ThrowIfNull(transaction);
        using NpgsqlConnection connection = DBConnect.Connection();
        using var command = new NpgsqlCommand();
        command.Connection = connection;
        command.CommandText =
            "insert into transactions (sum, account_id) values (@sum, @account_id);";
        NpgsqlParameter npgsqlParameter = command.Parameters.AddWithValue("@sum", transaction.Sum);
        command.Parameters.AddWithValue("@account_id", transaction.AccountId);
        connection.Open();
        command.ExecuteNonQuery();

        command.CommandText = "UPDATE accounts SET balance = balance + @newBalance where id = @id;";
        command.Parameters.AddWithValue("@newBalance", transaction.Sum);
        command.Parameters.AddWithValue("@id", transaction.AccountId);
        command.ExecuteNonQuery();
    }

    public int CreateAccount(int pin)
    {
        using NpgsqlConnection connection = DBConnect.Connection();
        using var command = new NpgsqlCommand();
        command.Connection = connection;
        command.CommandText = "insert into accounts (pin, balance) VALUES  (@pin, 0);";

        command.Parameters.AddWithValue("@pin", pin);
        connection.Open();
        command.ExecuteNonQuery();
        command.CommandText = "select max(account_id) from accounts;";
        NpgsqlDataReader reader = command.ExecuteReader();
        reader.Read();
        return reader.GetInt32(0);
    }

    public Account? GetAccountById(int id)
    {
        using NpgsqlConnection connection = DBConnect.Connection();
        using var command = new NpgsqlCommand();

        command.Connection = connection;
        command.CommandText = "select id, pin, balance from accounts where id = @id";
        command.Parameters.AddWithValue("@id", id);
        connection.Open();

        NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
        {
            return null;
        }

        return new Account(
            reader.GetInt32(0),
            reader.GetInt32(1),
            reader.GetDecimal(2));
    }

    public Admin? GetAdminByUsername(string username)
    {
        using NpgsqlConnection connection = DBConnect.Connection();
        using var command = new NpgsqlCommand();

        command.Connection = connection;
        command.CommandText = "select username, password from admins where username = @username";
        command.Parameters.AddWithValue("@username", username);
        connection.Open();

        NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
        {
            return null;
        }

        return new Admin(
            reader.GetString(0),
            reader.GetString(1));
    }
}

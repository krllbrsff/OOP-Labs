using Npgsql;

namespace Migrations;
public static class DBConnect
{
    public static NpgsqlConnection Connection()
    {
        return new(@"Host=postgres;Port=5432;Username=postgres;Password=postgres;Database=postgres;");
    }
}
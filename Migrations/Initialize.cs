using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;
namespace Infrastructure;
[Migration(1, "Initial")]
public class Initialize : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
        """
            create table accounts
            (
                id int primary key generated always as identity,
                pin int not null,
                balance money not null
            );

            create table transactions
            (
                transaction_id int primary key generated always as identity,
                account_id int not null,
                sum decimal not null
            );

            create table admins
            (
                username varchar(15) primary key,
                password varchar(15)
            )
            """;

    protected override string GetDownSql(IServiceProvider serviceProvider) =>
        """
            drop table accounts;
            drop table operations;
            drop table admins;
            """;
}

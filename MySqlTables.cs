using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace ProjectOrganization;

internal class Table<TData> : DbContext where TData : class
{
    private readonly MySqlConnection connection;

    public Table(MySqlConnection connection)
    {
        this.connection = connection;
    }

    public DbSet<TData> Rows => Set<TData>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseMySQL(connection);
    }
}
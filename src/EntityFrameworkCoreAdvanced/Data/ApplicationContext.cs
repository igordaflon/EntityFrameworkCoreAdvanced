using EntityFrameworkCoreAdvanced.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkCoreAdvanced.Data;

public class ApplicationContext : DbContext
{
    public DbSet<Departamento> Departamento { get; set; }
    public DbSet<Funcionario> Funcionario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string ConnectionString = "";
        var version = ServerVersion.Parse("8.0.40");
        optionsBuilder
            .UseMySql(ConnectionString, version)
            .EnableSensitiveDataLogging()
            .LogTo(Console.WriteLine, LogLevel.Information);
    }
}
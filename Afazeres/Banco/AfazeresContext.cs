
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Common;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using Afazeres;

namespace Afazeres.Banco;

internal class AfazeresContext : DbContext
{
    public DbSet<Tarefas> Tarefas { get; set; }

    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Afazeres;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

}

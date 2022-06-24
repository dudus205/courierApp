using DistributedTravelingSalesman.Domain;
using Microsoft.EntityFrameworkCore;

namespace DistributedTravellingSalesman.Infrastructure;

public class TravellingSalesmanDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<ParcelEntity> Parcels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }
}
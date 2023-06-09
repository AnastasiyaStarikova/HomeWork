using Microsoft.EntityFrameworkCore;
using Cinema.Entities;

namespace Cinema.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Film> Films { get; set; }
    public DbSet<Hall> Halls { get; set; }
    public DbSet<Sessions> Sessions { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<Reserv> Reservs { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
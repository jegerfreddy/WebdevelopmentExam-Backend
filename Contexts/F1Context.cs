using Microsoft.EntityFrameworkCore;
using F1API.Models;

namespace F1API.Contexts;

public class F1Context : DbContext
{
    public F1Context(DbContextOptions<F1Context> options):base(options){}

    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Race> Races { get; set; }
}
using Microsoft.EntityFrameworkCore;
using MyFi.Models;

public class MyFiDbContext : DbContext
{
    public MyFiDbContext(DbContextOptions<MyFiDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}
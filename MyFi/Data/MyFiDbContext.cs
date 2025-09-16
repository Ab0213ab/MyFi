using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFi.Models;

public class MyFiDbContext : IdentityDbContext
{
    public MyFiDbContext(DbContextOptions<MyFiDbContext> options) : base(options) { }

    public DbSet<Expense> Expenses { get; set; }
}
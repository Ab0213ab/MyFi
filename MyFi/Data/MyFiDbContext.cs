using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFi.Data.Infrastructure.DataSeeders;
using MyFi.Models;

public class MyFiDbContext : IdentityDbContext
{
    public MyFiDbContext(DbContextOptions<MyFiDbContext> options) : base(options) { }

    public DbSet<Budget> Budgets { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<BudgetTemplate> BudgetTemplates { get; set; }
    public DbSet<ExpenseTemplate> ExpenseTemplates { get; set; }
    public DbSet<CategoryTemplate> CategoryTemplates { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        BudgetTemplateSeeder.Seed(modelBuilder);
    }
}
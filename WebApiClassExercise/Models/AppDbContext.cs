using Microsoft.EntityFrameworkCore;

namespace WebApiClassExercise.Models
{
    public class AppDbContext : DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Expenseline> Expenselines{ get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
    {

    }

    }

}

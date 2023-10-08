using Microsoft.EntityFrameworkCore;

namespace Expense_Traker.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Category> categories { get; set; }
        public DbSet<Transaction> transactions { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using GroceryListManager.Models;

namespace GroceryListManager.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }
        public DbSet<Item> Item { get; set; }
    }
}
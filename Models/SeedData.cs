using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace GroceryListManager.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                // GATTUSMP: SAMPLE OF A SEED FILE THAT FIRST LOOKS FOR A DATABASE WITH DATA
                //           IF NO DATA FOUND THEN DATA IS ADDED TO THE DATABASE
                // // Look for any movies.
                 if (context.Item.Any())
                 {
                     return;   // DB has been seeded
                 }

                context.Item.AddRange(
                    new Item { Name = "Bread", Price= 3, quantity = 2 },
                    new Item { Name=  "Cheese", Price= 4, quantity = 2 },
                    new Item { Name = "Eggs", Price= 5, quantity = 10 },
                    new Item { Name = "Chocolate cake", Price= 5, quantity = 2 },
                    new Item { Name = "Beer", Price= 10, quantity = 2 }
                );
                context.SaveChanges();
            }
        }
    }
}
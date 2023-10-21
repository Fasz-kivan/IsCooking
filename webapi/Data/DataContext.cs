using Microsoft.EntityFrameworkCore;
using webapi.Entities;

namespace webapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DataContext(DbSet<Recipe> recipe)
        {
            Recipe = recipe ?? throw new ArgumentNullException(nameof(recipe));
        }

        public DbSet<Recipe> Recipe { get; set; }

    }
}

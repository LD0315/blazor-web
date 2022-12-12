using blazor_web.Shared;
using Microsoft.EntityFrameworkCore;

namespace blazor_web.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
  
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<Product> Products { get; set; }
    }
    
}

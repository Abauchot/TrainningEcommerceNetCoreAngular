using Microsoft.EntityFrameworkCore;
using TrainingEcommerce.Server.Models;
using TrainningEcommerce.Server.Models;

namespace TrainningEcommerce.Server.Data
{
    public class ApplicationDbContext: DbContext
    {
     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

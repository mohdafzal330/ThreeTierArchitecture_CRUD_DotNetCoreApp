using Microsoft.EntityFrameworkCore;
using Models.DataModels;

namespace Models.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { set; get; }
    }
}
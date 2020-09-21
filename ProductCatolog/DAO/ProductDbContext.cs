using Microsoft.EntityFrameworkCore;
using ProductCatolog.Models;

namespace ProductCatolog.DAO
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
        public DbSet<ProductModel> products{get;set;}
    }
}
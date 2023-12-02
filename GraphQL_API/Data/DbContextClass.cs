using GraphQL_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_API.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass>options) : base(options)
        {

        }

        public DbSet<ProductDetails> Products { get; set; }
    }
}

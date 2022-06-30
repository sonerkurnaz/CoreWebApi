using HttpStatusCode.Infrastructure.SeedData;
using HttpStatusCode.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HttpStatusCode.Infrastructure.Context
{
    public class SqlDbcontext : DbContext
    {
        public SqlDbcontext()
        {

        }
        public SqlDbcontext(DbContextOptions<SqlDbcontext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategorySeedData());
        }
    }
}

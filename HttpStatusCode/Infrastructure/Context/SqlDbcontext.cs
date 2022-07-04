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
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategorySeedData());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"server=.;Database=WebApiDb;User Id=sa;Password=123");
        }
    }
}

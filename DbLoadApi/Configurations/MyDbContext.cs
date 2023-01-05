using DbLoadApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DbLoadApi.Configurations
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enchantment>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Equipment>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Player>()
                .HasKey(p => p.Id);
            
            modelBuilder.Entity<Weapon>()
                .HasKey(w => w.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}

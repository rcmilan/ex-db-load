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

            modelBuilder.Entity<Player>()
                .Property(p => p.Health)
                .HasDefaultValue(100)
                .IsRequired();

            modelBuilder.Entity<Player>()
                .Property<bool>("IsDeleted");

            modelBuilder.Entity<Player>()
                .HasQueryFilter(p => EF.Property<bool>(p, "IsDeleted") == false);

            modelBuilder.Entity<Weapon>()
                .HasKey(w => w.Id);

            modelBuilder.Entity<Player>()
                .OwnsMany(p => p.WeaponInventory);

            modelBuilder.Entity<Player>()
                .OwnsMany(p => p.EquipmentInventory);

            modelBuilder.Entity<Player>()
                .Property(p => p.Job)
                .HasConversion<string>();

            modelBuilder.Entity<Weapon>()
                .Property(w => w.Type)
                .HasConversion<string>();

            modelBuilder.Entity<Equipment>()
                .Property(e => e.Type)
                .HasConversion<string>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
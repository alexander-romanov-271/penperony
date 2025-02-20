using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Penperony.DAL.Entities
{
    public class MainDbContext(DbContextOptions<MainDbContext> options) : DbContext(options)
    {
        public DbSet<TriggerEntity> Trigger { get; set; }
        public DbSet<ProductEntity> Product { get; set; }
        public DbSet<ProviderEntity> Provider { get; set; }
        public DbSet<SellerEntity> Seller { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TriggerConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProviderConfiguration());
            modelBuilder.ApplyConfiguration(new SellerConfiguration());
        }

    }

    public class ProviderConfiguration : IEntityTypeConfiguration<ProviderEntity>
    {
        public void Configure(EntityTypeBuilder<ProviderEntity> builder)
        {
            builder
                .HasMany(p => p.Triggers)
                .WithMany(t => t.Providers);
        }
    }

    public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder
                .HasMany(p => p.Triggers)
                .WithMany(t => t.Products);
        }
    }

    public class SellerConfiguration : IEntityTypeConfiguration<SellerEntity>
    {
        public void Configure(EntityTypeBuilder<SellerEntity> builder)
        {
            builder
                .HasMany(s => s.Triggers)
                .WithMany(t => t.Sellers);
        }
    }

    public class TriggerConfiguration : IEntityTypeConfiguration<TriggerEntity>
    {
        public void Configure(EntityTypeBuilder<TriggerEntity> builder)
        {
            builder
                .HasMany(t => t.Providers)
                .WithMany(builder => builder.Triggers);

            builder
                .HasMany(t => t.Sellers)
                .WithMany(s => s.Triggers);

            builder
                .HasMany(t => t.Products)
                .WithMany(p => p.Triggers);
        }
    }
}


using Microsoft.EntityFrameworkCore;
using Octy.Domain;
using Octy.Domain.Common;

namespace Octy.Persistence
{
    public class OctyDbContext : DbContext
    {
        public OctyDbContext(DbContextOptions<OctyDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OctyDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.UpdatedDate = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<ElementAttribute> ElementAttributes { get; set; }
        public DbSet<Element> Elements { get; set; }
    }
}

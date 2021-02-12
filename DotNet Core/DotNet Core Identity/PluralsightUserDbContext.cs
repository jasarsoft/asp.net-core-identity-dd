using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNet_Core_Identity
{
    public class PluralsightUserDbContext : IdentityDbContext<PluralsightUser>
    {
        public PluralsightUserDbContext(DbContextOptions<PluralsightUserDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PluralsightUser>(user => user.HasIndex(p => p.Locale).IsUnique(false));

            builder.Entity<Organizaion>(org =>
            {
                org.ToTable(nameof(Organizaion));
                org.HasKey(p => p.Id);

                org.HasMany<PluralsightUser>().WithOne().HasForeignKey(p => p.OrdId).IsRequired(false);
            });
        }
    }
}

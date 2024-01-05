using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Octy.Identity.Models;

namespace Octy.Identity.DbContext;

public class OctyIdentityDbContext : IdentityDbContext<ApplicationUser>
{
    public OctyIdentityDbContext
        (DbContextOptions<OctyIdentityDbContext> options)
    : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(OctyIdentityDbContext).Assembly);
    }
}
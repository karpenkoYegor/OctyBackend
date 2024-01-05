using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Octy.Identity.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "fa0c5faf-e834-430d-a250-3a740490c82d",
                UserId = "a0b8fa95-49b4-4cd9-9674-1a5f6eae07f6",
            },
            new IdentityUserRole<string>()
            {
                RoleId = "a69efaf0-ba14-42c5-a71a-0a42e6db0609",
                UserId = "afe3c7ff-945c-421d-b8a6-8360797bf1a3"
            }
        );
    }
}
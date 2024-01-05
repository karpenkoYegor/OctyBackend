using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Octy.Identity.Models;

namespace Octy.Identity.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        builder.HasData(
            new ApplicationUser
            {
                Id = "a0b8fa95-49b4-4cd9-9674-1a5f6eae07f6",
                Email = "admin@ya.ru",
                NormalizedEmail = "ADMIN@YA.RU",
                FirstName = "Admin",
                LastName = "Admin",
                UserName = "admin@ya.ru",
                NormalizedUserName = "ADMIN@YA.RU",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            },
            new ApplicationUser
            {
                Id = "afe3c7ff-945c-421d-b8a6-8360797bf1a3",
                Email = "octystudent@ya.ru",
                NormalizedEmail = "OCTYSTUDENT@YA.RU",
                FirstName = "student",
                LastName = "student",
                UserName = "octystudent@ya.ru",
                NormalizedUserName = "OCTYSTUDENT@YA.RU",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            }
        );
    }
}
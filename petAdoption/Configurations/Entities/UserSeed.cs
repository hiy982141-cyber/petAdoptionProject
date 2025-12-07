using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using petAdoption.Data; // Assuming ApplicationUser is here

namespace petAdoption.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4", // Admin User GUID
                    Email = "admin@petportal.com",
                    NormalizedEmail = "ADMIN@PETPORTAL.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@petportal.com",
                    NormalizedUserName = "ADMIN@PETPORTAL.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"), // Password: P@ssword1
                    EmailConfirmed = true
                }
            );
        }
    }
}
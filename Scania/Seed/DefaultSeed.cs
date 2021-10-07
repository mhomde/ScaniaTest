using System;
using Microsoft.AspNetCore.Identity;
using Scania.Data;
using Scania.Objects;

namespace Scania.Seed
{
    public class DefaultSeed
    {
        private static readonly PasswordHasher<IdentityUser> PasswordHasher = new PasswordHasher<IdentityUser>();

        public DefaultSeed()
        {
            AdminUser.PasswordHash = PasswordHasher.HashPassword(AdminUser, AdminPassword);
            AdminUser.AddNormalized();

            BasicUser.PasswordHash = PasswordHasher.HashPassword(BasicUser, UserPassword);
            BasicUser.AddNormalized();
        }


        public IdentityUser BasicUser { get; } = new IdentityUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = BasicEmail,
            Email = BasicEmail,
            LockoutEnabled = false,
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString()
        };

        public IdentityUser AdminUser { get; }
            = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = AdminEmail,
                Email = AdminEmail,
                LockoutEnabled = false,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString()
            };

        public IdentityRole AdminRole { get; } =
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = Roles.Admin.ToString(),
                Id = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

        public IdentityRole BasicRole { get; } =
            new IdentityRole
            {
                Name = "User",
                NormalizedName = Roles.Basic.ToString(),
                Id = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

        public string AdminPassword { get; }
            = "Test123_";

        public string UserPassword { get; }
            = "Test123_";

        public static string AdminEmail { get; }
            = "admin@test.com";

        public static string BasicEmail { get; }
            = "user@test.com";

      
    }
}
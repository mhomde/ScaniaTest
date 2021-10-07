using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Scania.Seed
{
    public static class ModelUtils
    {
        public static IdentityRole SeedRole(this ModelBuilder builder, IdentityRole role)
        {
            builder.Entity<IdentityRole>().HasData(role);

            return role;
        }

        public static IdentityUser SeedUser(this ModelBuilder builder, IdentityUser user)
        {
            builder.Entity<IdentityUser>().HasData(user);

            return user;
        }

        public static IdentityUserRole<string> SeedUserRole(this ModelBuilder builder, IdentityUser user, IdentityRole role)
        {
            var userRole = new IdentityUserRole<string> {RoleId = role.Id, UserId = user.Id};
            builder.Entity<IdentityUserRole<string>>().HasData(userRole);

            return userRole;
        }
    }
}
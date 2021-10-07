using Microsoft.EntityFrameworkCore;

namespace Scania.Seed
{
    public class ModelInstaller
    {
        public void InstallModel(ModelBuilder builder, DefaultSeed seed)
        {

            builder.SeedRole(seed.AdminRole);
            builder.SeedRole(seed.BasicRole);

            builder.SeedUser(seed.BasicUser);
            builder.SeedUser(seed.AdminUser);

            builder.SeedUserRole(seed.BasicUser, seed.BasicRole);
            builder.SeedUserRole(seed.AdminUser, seed.AdminRole);

        }
    }
}
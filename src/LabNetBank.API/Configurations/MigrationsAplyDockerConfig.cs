using LabNetBank.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace LabNetBank.API.Configurations
{
    public static class MigrationsAplyDockerConfig
    {
        public static void MigrationsAplyDocker(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var serviceDb = serviceScope.ServiceProvider.GetService<LabNetBankContext>();

                serviceDb.Database.Migrate();
            }
        }
    }
}

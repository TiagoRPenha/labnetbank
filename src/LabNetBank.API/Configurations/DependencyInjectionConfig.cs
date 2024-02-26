using LabNetBank.Business.Interfaces.Repositories;
using LabNetBank.Business.Interfaces.Services;
using LabNetBank.Business.Services;
using LabNetBank.Infrastructure.Context;
using LabNetBank.Infrastructure.Repositories;
using System.Runtime.CompilerServices;

namespace LabNetBank.API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<LabNetBankContext>();

            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ITransferRepository, TransferRepository>();
            services.AddScoped<IHolderRepository, HolderRepository>();

            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITransferService, TransferService>();
            services.AddScoped<IHolderService, HolderService>();

            return services;
        }
    }
}

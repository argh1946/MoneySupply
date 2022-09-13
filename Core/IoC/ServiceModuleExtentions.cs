using Core.Contracts;
using Core.Contracts.AtmCrs;
using Core.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Core.IoC
{
    public static class ServiceModuleExtentions
    {
        public static void RegisterCoreServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAtmCrsService, AtmCrsService>();            
        }
    }
}

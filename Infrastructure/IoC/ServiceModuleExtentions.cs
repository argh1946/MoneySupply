using Microsoft.Extensions.DependencyInjection;
using Core.Contracts;
using Infrastructure.Data;
using System.Linq;
using Core.Contracts.AtmCrs;
using Core.Contracts.MoneyType;
using Core.Contracts.Status;
using Infrastructure.Data.Repositories;
using Core.Contracts.RequestStatus;
using Core.Contracts.Request;
using Core.Contracts.FileAttachment;
using Core.Contracts.User;

namespace Infrastructure.IoC
{
    public static class ServiceModuleExtentions
    {
        public static void RegisterInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<IUnitOfWorkSon, UnitOfWorkSon>();

            serviceCollection.AddScoped<IAtmCrsRepository, AtmCrsRepository>();           
            serviceCollection.AddScoped<IMoneyTypeRepository, MoneyTypeRepository>();           
            serviceCollection.AddScoped<IStatusRepository, StatusRepository>();           
            serviceCollection.AddScoped<IRequestStatusRepository, RequestStatusRepository>();           
            serviceCollection.AddScoped<IRequestMoneySupplyRepository, RequestMoneySupplyRepository>();           
            serviceCollection.AddScoped<IRequestEFardaRepository, RequestEFardaRepository>();           
            serviceCollection.AddScoped<IRequestOperationDepartmentRepository, RequestOperationDepartmentRepository>();           
            serviceCollection.AddScoped<IRequestTearsuryAssistantRepository, RequestTearsuryAssistantRepository>();           
            serviceCollection.AddScoped<IRequestTreasuryAccountantRepository, RequestTreasuryAccountantRepository>();           
            serviceCollection.AddScoped<IRequestTreasuryManagerRepository, RequestTreasuryManagerRepository>();           
            serviceCollection.AddScoped<IFileAttachmentRepository, FileAttachmentRepository>(); 
            
            serviceCollection.AddScoped<IUserRepository, UserRepository>();           
        }
    }
}
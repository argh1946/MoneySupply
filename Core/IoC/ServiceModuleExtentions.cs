using Core.Contracts;
using Core.Contracts.AtmCrs;
using Core.Contracts.FileAttachment;
using Core.Contracts.MoneyType;
using Core.Contracts.Request;
using Core.Contracts.RequestStatus;
using Core.Contracts.Status;
using Core.Contracts.User;
using Core.Entities;
using Core.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Core.IoC
{
    public static class ServiceModuleExtentions
    {
        public static void RegisterCoreServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAtmCrsService, AtmCrsService>();
            serviceCollection.AddScoped<IMoneyTypeService, MoneyTypeService>();
            serviceCollection.AddScoped<IStatusService, StatusService>();
            serviceCollection.AddScoped<IRequestStatusService, RequestStatusService>();
            serviceCollection.AddScoped<IRequestStatusService, RequestStatusService>();
            serviceCollection.AddScoped<IRequestMoneySupplyService, RequestMoneySupplyService>();
            serviceCollection.AddScoped<IRequestEFardaService, RequestEFardaService>();
            serviceCollection.AddScoped<IRequestOperationDepartmentService, RequestOperationDepartmentService>();
            serviceCollection.AddScoped<IRequestTearsuryAssistantService, RequestTearsuryAssistantService>();
            serviceCollection.AddScoped<IRequestTreasuryAccountantService, RequestTreasuryAccountantService>();
            serviceCollection.AddScoped<IRequestTreasuryManagerService, RequestTreasuryManagerService>();
            serviceCollection.AddScoped<IFileAttachmentService ,FileAttachmentService>();

            serviceCollection.AddScoped<IUserService, UserService>();
        }
    }
}

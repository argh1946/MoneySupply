using AutoMapper;
using Core.Entities;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using React.Mapper;

namespace React.IoC
{
    public static class RegisterAutoMapper
    {
        public static void RegisterAutoMapperService(this IServiceCollection serviceCollection)
        {
            var automapper = RegisterAutoMapperService();
            serviceCollection.AddSingleton(automapper);
            //serviceCollection.AddScoped<IValidator<Status>, StatusValidator>();

        }

        private static IMapper RegisterAutoMapperService()
        {
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            return mapper;
        }
    }
}

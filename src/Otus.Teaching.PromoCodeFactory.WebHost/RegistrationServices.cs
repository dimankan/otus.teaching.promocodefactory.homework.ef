using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.DataAccess;
using Otus.Teaching.PromoCodeFactory.DataAccess.Repositories;
using Otus.Teaching.PromoCodeFactory.Services.Contracts;
using Otus.Teaching.PromoCodeFactory.Services.Mapping;
using Otus.Teaching.PromoCodeFactory.Services.Services;
using Otus.Teaching.PromoCodeFactory.WebHost.Map;

namespace Otus.Teaching.PromoCodeFactory.WebHost
{
    public static class RegistrationServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            InstallAutomapper(services);

            var applicationSettings = configuration.Get<ApplicationSettings>();

            services.AddSingleton(applicationSettings)
                    .AddSingleton((IConfigurationRoot)configuration)
                    .InstallServices()
                    .ConfigureContext(applicationSettings.ConnectionString)
                    .InstallRepositories()
                    .AddScoped<IDataInitializer, EFDataInitializer>();

            return services;
        }
        private static IServiceCollection InstallAutomapper(IServiceCollection services)
        {
            services.AddSingleton<IMapper>(new Mapper(GetMapperConfiguration()));
            return services;
        }
        private static MapperConfiguration GetMapperConfiguration()
        {
            var configuration = new MapperConfiguration(config =>
            {
                config.AddProfile<CustomerMappingsProfileForApi>();
                config.AddProfile<CustomerMappingsProfile>();

                config.AddProfile<CustomerPreferenceMappingsProfileForApi>();
                config.AddProfile<CustomerPreferenceMappingsProfile>();
            });
            configuration.AssertConfigurationIsValid();
            return configuration;
        }
        private static IServiceCollection InstallServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IEmployeeService, EmployeeService>()
                .AddTransient<IRoleService, RoleService>()
                .AddTransient<ICustomerService, CustomerService>()
                .AddTransient<IPreferenceService, PreferenceService>();
            return serviceCollection;
        }
        public static IServiceCollection ConfigureContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DatabaseContext>(optionsBuilder
                => optionsBuilder
                    .UseSqlite(connectionString));

            return services;
        }
        private static IServiceCollection InstallRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IEmployeeRepository, EmployeeRepository>()
                .AddTransient<IRoleRepository, RoleRepository>()
                .AddTransient<ICustomerRepository, CustomerRepository>()
                .AddTransient<IPreferenceRepository, PreferenceRepository>();
            return serviceCollection;
        }
    }
}

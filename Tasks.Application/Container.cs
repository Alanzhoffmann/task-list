using System;
using Microsoft.Extensions.DependencyInjection;
using Tasks.Infra;

namespace Tasks.Application
{
    public static class Container
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            AddApplicationServices(services);
            AddServices(services);
            AddRepositories(services);

            services.AddSingleton<ConnectionString>();

            return services;
        }

        private static void AddApplicationServices(IServiceCollection services)
        {
            throw new NotImplementedException();
        }

        private static void AddServices(IServiceCollection services)
        {
            throw new NotImplementedException();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            throw new NotImplementedException();
        }
    }
}

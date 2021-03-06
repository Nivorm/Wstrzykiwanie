using Wstrzykiwanie.Interfaces;
using Data.Repository;
using Wstrzykiwanie.Services;

namespace Wstrzykiwanie
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            return services;
        }
    }
}

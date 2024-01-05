using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Identity.Application.Common.Interfaces;
using Identity.Infrastructure.Security.TokenGenerator;

namespace Identity.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
           IConfiguration configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.Section));

            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, SystemDataTimeProvider>();

            return services;
        }
    }
}

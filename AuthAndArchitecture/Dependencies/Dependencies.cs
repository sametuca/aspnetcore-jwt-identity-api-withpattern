using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace AuthAndArchitecture.Dependencies
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterRequestHandlers(
            this IServiceCollection services)
        {
            return services
                .AddMediatR(typeof(Dependencies).Assembly);
        }
    }
}

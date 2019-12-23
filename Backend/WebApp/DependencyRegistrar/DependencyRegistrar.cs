using Microsoft.Extensions.DependencyInjection;
using T.Host.Token;

namespace T.WebApp
{
    public static class DependencyRegistrar
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IAuthentication, Authentication>();
        }
    }
}

using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICombinadorDeStringService, CombinadorDeStringService>()
            .AddScoped<ITesteService, TesteService>();
        }
    }
}

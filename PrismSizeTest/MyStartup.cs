using Microsoft.Extensions.DependencyInjection;
using PrismSizeTest.Delegates;
using Shiny;
using Shiny.Locations;
using Shiny.Prism;

namespace PrismSizeTest
{
    public class MyStartup : PrismStartup
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            services.UseGps<GpsDelegate>();
        }
    }
}
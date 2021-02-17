using System.Threading.Tasks;
using Shiny.Locations;

namespace PrismSizeTest.Delegates
{
    public class GpsDelegate : IGpsDelegate
    {
        public Task OnReading(IGpsReading reading)
        {
            return Task.CompletedTask;
        }
    }
}
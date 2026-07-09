using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(SurveyUP.Areas.Identity.IdentityHostingStartup))]
namespace SurveyUP.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
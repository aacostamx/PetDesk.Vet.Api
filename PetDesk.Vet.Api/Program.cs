using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.CodeAnalysis;

namespace PetDesk.Vet.Api
{
    [ExcludeFromCodeCoverage]
    public static class Program
    {
        public static void Main()
        {
            CreateHostBuilder().Build().Run();
        }

        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

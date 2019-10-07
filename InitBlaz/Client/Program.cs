using Microsoft.AspNetCore.Blazor.Hosting;

namespace InitBlaz.Client
{
    static class Constants
    {
        public const string URL_Base = "http://localhost:57931/";
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
    }
}

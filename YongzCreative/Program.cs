using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace YongzCreative
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .CaptureStartupErrors(true) // the default
                    .UseSetting("detailedErrors", "true")
                    .UseStartup<Startup>()
                    .UseDefaultServiceProvider(options =>
                            options.ValidateScopes = false);
    }
}

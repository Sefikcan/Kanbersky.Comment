using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Sentry;

namespace Kanbersky.Comment.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (SentrySdk.Init("https://7e79ea6cf6834f628080ac9a0642fa4f@sentry.io/2020143"))
            {
                CreateWebHostBuilder(args).Build().Run();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

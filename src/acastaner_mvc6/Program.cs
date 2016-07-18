using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace acastaner_mvc6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls("http://127.0.0.1:5000")
                .Build();

            host.Run();
        }
    }
}

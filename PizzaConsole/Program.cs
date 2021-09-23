using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace OrderPizza
{
    public class Startup
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                ServiceCollection services = new();
                services.AddHttpClient();
                ServiceProvider service = services.BuildServiceProvider();
                Window window = new(service.GetService<HttpClient>());
                Task.WaitAll(window.RunConsole());
            }
        }
    }
}
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Threading.Tasks;

namespace MySuperImportantService
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            IConfiguration configuration = ConfigurationFactory.GetConfiguration();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            Log.Information("Good day! This is the {applicationName} speaking, I am now starting", nameof(MySuperImportantService));

            TimeSpan runningInterval = TimeSpan.FromSeconds(10); 
            while (true)
            {
                Log.Information("{applicationName} is now doing it's superimportant work", nameof(MySuperImportantService));

                await Task.Delay(runningInterval);
            }
        }
    }
}

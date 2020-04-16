using System.IO;
using Microsoft.Extensions.Configuration;

namespace MySuperImportantService
{
    public static class ConfigurationFactory
    {
        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appsettings.json")
                       .AddJsonFile("secrets.json", true);
            var configuration = builder.Build();

            return configuration;
        }
    }
}

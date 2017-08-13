namespace Project.Tests
{
    using Microsoft.Extensions.Configuration;
    public class Startup
    {
        public Startup(ConfigurationEnv env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);
                
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }
    }

    public class ConfigurationEnv
    {
        public ConfigurationEnv(string contentRootPath, string environmentName)
        {
            ContentRootPath = contentRootPath;
            EnvironmentName = environmentName;
        }
        internal string ContentRootPath {get; private set;}
        internal string EnvironmentName {get; private set;}
    }
}
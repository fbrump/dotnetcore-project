namespace Project.Tests
{
    using System.IO;

    public abstract class BaseTest
    {
        protected Startup _configuration;
        public BaseTest()
        {
            //this._configuration = new Startup(new ConfigurationEnv(Directory.GetCurrentDirectory(), "dev"));
            this._configuration = new Startup(new ConfigurationEnv("/Users/Brum/Documents/work/_git/core-vscode/test/Project.Tests/", "dev"));
        }
    }
}
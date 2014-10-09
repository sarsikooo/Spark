using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spark.WebUI.Startup))]
namespace Spark.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

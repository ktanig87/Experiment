using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Experiment.WebMVC.Startup))]
namespace Experiment.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

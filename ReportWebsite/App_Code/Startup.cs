using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReportWebsite.Startup))]
namespace ReportWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

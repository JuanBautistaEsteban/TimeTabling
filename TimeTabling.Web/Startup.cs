using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeTabling.Web.Startup))]
namespace TimeTabling.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

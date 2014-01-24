using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc51ApplicationFx451.Startup))]
namespace Mvc51ApplicationFx451
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

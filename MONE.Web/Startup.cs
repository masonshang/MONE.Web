using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MONE.Web.Startup))]
namespace MONE.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}

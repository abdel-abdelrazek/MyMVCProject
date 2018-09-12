using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVCWebsite.Startup))]
namespace MyMVCWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

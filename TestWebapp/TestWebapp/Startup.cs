using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebapp.Startup))]
namespace TestWebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

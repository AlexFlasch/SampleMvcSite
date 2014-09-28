using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleMvcSite.Startup))]
namespace SampleMvcSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

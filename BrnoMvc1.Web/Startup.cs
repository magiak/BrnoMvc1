using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrnoMvc1.Web.Startup))]
namespace BrnoMvc1.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

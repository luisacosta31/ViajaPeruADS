using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViajaPeru.Startup))]
namespace ViajaPeru
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

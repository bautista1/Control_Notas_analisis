using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlNotas.Startup))]
namespace ControlNotas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

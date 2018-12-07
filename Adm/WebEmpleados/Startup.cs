using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebEmpleados.Startup))]
namespace WebEmpleados
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

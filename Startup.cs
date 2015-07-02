using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FuncionariosIN3.Startup))]
namespace FuncionariosIN3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

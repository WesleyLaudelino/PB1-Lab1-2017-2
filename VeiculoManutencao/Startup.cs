using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VeiculoManutencao.Startup))]
namespace VeiculoManutencao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

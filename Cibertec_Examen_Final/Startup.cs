using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cibertec_Examen_Final.Startup))]
namespace Cibertec_Examen_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

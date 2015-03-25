using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RosieCastro.Startup))]
namespace RosieCastro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_CommerceAppUI.Startup))]
namespace E_CommerceAppUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

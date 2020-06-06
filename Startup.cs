using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TerminalDeViale.Startup))]
namespace TerminalDeViale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

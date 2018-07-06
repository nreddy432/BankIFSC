using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankIFSC.Startup))]
namespace BankIFSC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

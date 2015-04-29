using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sozialheap.Startup))]
namespace Sozialheap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

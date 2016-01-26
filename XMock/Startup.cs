using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XMock.Startup))]
namespace XMock
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

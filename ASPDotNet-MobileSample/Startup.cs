using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPDotNet_MobileSample.Startup))]
namespace ASPDotNet_MobileSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

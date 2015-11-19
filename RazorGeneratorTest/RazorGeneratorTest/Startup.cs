using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RazorGeneratorTest.Startup))]
namespace RazorGeneratorTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

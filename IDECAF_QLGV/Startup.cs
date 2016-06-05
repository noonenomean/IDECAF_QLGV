using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IDECAF_QLGV.Startup))]
namespace IDECAF_QLGV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

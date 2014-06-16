using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MonsterHelper.Startup))]
namespace MonsterHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

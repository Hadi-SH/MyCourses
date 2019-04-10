using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyCourses.Startup))]
namespace MyCourses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

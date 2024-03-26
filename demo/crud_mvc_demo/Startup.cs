using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crud_mvc_demo.Startup))]
namespace crud_mvc_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

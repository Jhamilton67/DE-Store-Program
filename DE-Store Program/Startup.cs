using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DE_Store_Program.Startup))]
namespace DE_Store_Program
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

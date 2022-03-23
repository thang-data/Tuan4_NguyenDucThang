using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan4_NguyenDucThang.Startup))]
namespace Tuan4_NguyenDucThang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

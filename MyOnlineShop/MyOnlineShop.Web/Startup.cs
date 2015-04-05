using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyOnlineShop.Web.Startup))]
namespace MyOnlineShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}

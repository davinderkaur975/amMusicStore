using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(amMusicStore.Startup))]
namespace amMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChallengeMe.UI.Web.Startup))]
namespace ChallengeMe.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

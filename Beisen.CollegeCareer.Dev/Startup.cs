using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Beisen.CollegeCareer.Dev.Startup))]
namespace Beisen.CollegeCareer.Dev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

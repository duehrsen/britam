using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnglishQuiz.Startup))]
namespace EnglishQuiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

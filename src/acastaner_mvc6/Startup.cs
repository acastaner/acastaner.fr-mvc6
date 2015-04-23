using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace acastaner_mvc6
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
			app.UseStaticFiles();
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller}/{action}/{id?}",
					defaults: new { controller = "Home", action = "Index" });
			});
		}
    }
}

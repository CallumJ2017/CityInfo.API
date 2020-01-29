using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;

namespace CityInfo.API
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			// Add services on the container and configure these services.
			services.AddMvc().AddMvcOptions(o =>
			{
				o.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler();
			}

			app.UseStatusCodePages();
			app.UseMvc();
		}
	}
}

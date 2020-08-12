using System.Net.Http;
using Going.Plaid.Demo.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Going.Plaid.Demo
{
	public class Startup
	{
		private readonly IConfiguration _config;
		public Startup(IConfiguration configuration)
		{
			_config = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc(o => o.EnableEndpointRouting = false);
			services.AddHttpClient();
			services.Configure<PlaidCredentials>(_config.GetSection(PlaidOptions.SectionKey));
			services.Configure<PlaidOptions>(_config.GetSection(PlaidOptions.SectionKey));
			services.AddSingleton<PlaidClient>();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();
			app.UseMvcWithDefaultRoute();
		}
	}
}

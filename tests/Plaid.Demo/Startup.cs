using System.Net.Http;
using Going.Plaid.Demo.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Going.Plaid.Demo
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc(o => o.EnableEndpointRouting = false);
			services.AddHttpClient();
			services.AddSingleton<PlaidCredentials>();
			services.AddSingleton(
				sp =>
				{
					var credentials = sp.GetRequiredService<PlaidCredentials>();
					return new PlaidClient(
						credentials.Environment,
						credentials.ClientId,
						credentials.Secret,
						httpClientFactory: sp.GetRequiredService<IHttpClientFactory>());
				});
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

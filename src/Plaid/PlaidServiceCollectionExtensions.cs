namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Holding class for extension methods.
/// </summary>
public static class PlaidServiceCollectionExtensions
{
	/// <summary>
	/// Registers all of the Plaid infrastructure, including <see cref="PlaidOptions"/> 
	/// configuration data stored in the <see cref="PlaidOptions.SectionKey"/> (<c>"Plaid"</c>)
	/// section of the provided configuration root.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to add the services to</param>
	/// <param name="configurationRoot">The configuration root that holds a <c>"Plaid"</c> section of configuration data for Plaid</param>
	/// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained</returns>
	public static IServiceCollection AddPlaid(
		this IServiceCollection services,
		IConfigurationRoot configurationRoot)
		=> services.AddPlaid(configurationRoot.GetSection(PlaidOptions.SectionKey));

	/// <summary>
	/// Registers all of the Plaid infrastructure, including <see cref="PlaidOptions"/> 
	/// configuration data stored in the provided configuration section.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to add the services to</param>
	/// <param name="configuration">The configuration being bound</param>
	/// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained</returns>
	public static IServiceCollection AddPlaid(
		this IServiceCollection services,
		IConfiguration configuration)
		=> services
			.Configure<PlaidOptions>(configuration)
			.AddPlaidHttpClient()
			.AddPlaidClient();

	/// <summary>
	/// Registers the <see cref="PlaidClient"/> as a singleton for use in the DI system.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to add the services to</param>
	/// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained</returns>
	public static IServiceCollection AddPlaidClient(
		this IServiceCollection services)
		=> services.AddSingleton<PlaidClient>();

	/// <summary>
	/// Registers a <c>"PlaidClient"</c> named HttpClient configured for Plaid usage.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to add the services to</param>
	/// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained</returns>
	public static IServiceCollection AddPlaidHttpClient(
		this IServiceCollection services)
	{
		services
			.AddHttpClient("PlaidClient")
			.ConfigurePrimaryHttpMessageHandler(() =>
				new HttpClientHandler
				{
					AutomaticDecompression = System.Net.DecompressionMethods.All,
				});
		return services;
	}
}

namespace Going.Plaid;

/// <summary>
/// Implements the IOptions pattern for reading a 'Plaid' section from an IConfiguration object.
/// </summary>
public class PlaidOptions
{
	/// <summary>
	/// A default name in the IConfiguration that contains PlaidOptions settings
	/// </summary>
	/// <remarks>
	/// Section name in configuration is configurable. This default is offered for
	/// convenience only.
	/// </remarks>
	public const string SectionKey = "Plaid";

	/// <summary>
	/// client_id is the same across all environments
	/// </summary>
	/// <remarks>
	/// See: <see href="https://plaid.com/docs/quickstart/#api-keys" />
	/// </remarks>
	public string? ClientId { get; set; } = null;

	/// <summary>
	/// you have a unique secret for each API environment
	/// </summary>
	/// <remarks>
	/// See: <see href="https://plaid.com/docs/quickstart/#api-keys" />
	/// </remarks>
	public string? Secret { get; set; } = null;

	/// <summary>
	/// OPTIONAL: Use to specify a default AccessToken for ALL requests that do not provide their own AccessToken 
	/// </summary>
	/// <remarks>
	/// NOTE: If you are acting as a User in a session (e.g. on a Web API), you probably don't want to set this system-wide. 
	///       It would be safer to use one <see cref="PlaidClient"/> system-wide and provide the AccessToken on each 
	///       API call.
	/// </remarks>
	public string? DefaultAccessToken { get; set; }

	/// <summary>
	/// <see cref="Going.Plaid.Environment"/>: Sandbox | Development | Production
	/// </summary>
	/// <remarks>
	/// See: <see href="https://plaid.com/docs/quickstart/#api-enviroments" />
	/// </remarks>
	public Environment Environment { get; set; } = Environment.Sandbox;

	/// <summary>
	/// <see cref="Going.Plaid.ApiVersion"/>: v20200914
	/// </summary>
	/// <remarks>
	/// See: <see href="https://plaid.com/docs/api-upgrades/"/>
	/// </remarks>
	public ApiVersion ApiVersion { get; set; } = ApiVersion.v20200914;
}

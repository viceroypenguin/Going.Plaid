using System;
using System.Collections.Generic;
using System.Text;

namespace Going.Plaid
{
	/// <summary>
	/// Implements the IOptions pattern for reading a 'Plaid' section from an IConfiguration object.
	/// </summary>
	public class PlaidOptions
	{
		/// <summary>
		/// The section name in the IConfiguration that contains PlaidOptions settings
		/// </summary>
		public const string SectionKey = "Plaid";

		/// <summary>
		/// client_id is the same across all environments
		/// !!! THIS SHOULD NEVER BE SHARED IN CLIENT-SIDE CODE !!!
		/// </summary>
		/// <remarks>
		/// See: https://plaid.com/docs/quickstart/#api-keys
		/// </remarks>
		public string? ClientId { get; set; } = null;

		/// <summary>
		/// you have a unique secret for each API environment
		/// !!! THIS SHOULD NEVER BE SHARED IN CLIENT-SIDE CODE !!!
		/// </summary>
		/// <remarks>
		/// See: https://plaid.com/docs/quickstart/#api-keys
		/// </remarks>
		public string? Secret { get; set; } = null;

		/// <summary>
		/// OPTIONAL: Use to specify a default AccessToken for ALL requests that do not provide their own AccessToken 
		/// NOTE: If you are acting as a User in a session (e.g. on a Web API), you probably don't want to set this system-wide. 
		///       It would be safer to use one <see cref="PlaidClient"/> for system-level operations, and a different client instance 
		///       to act as the User to ensure that the default access token is never attached on User-specific requests.
		/// </summary>
		public string? DefaultAccessToken
		{
			get => _defaultAccessToken;
			set => _defaultAccessToken = string.IsNullOrWhiteSpace(value) ? null : value;
		}
		private string? _defaultAccessToken;

		/// <summary>
		/// <see cref="Environment"/>: Sandbox | Development | Production
		/// </summary>
		/// <remarks>
		/// See: https://plaid.com/docs/quickstart/#api-enviroments
		/// </remarks>
		public Environment Environment { get; set; } = Environment.Sandbox;


		/// <summary>
		/// Convert the <see cref="Environment"/> string field into a <see cref="Plaid.Environment"/> value.
		/// </summary>
		/// <returns>the <see cref="Plaid.Environment"/> value equivalent of the <see cref="Environment"/> field (ignoring case)</returns>
		/// <exception cref="ArgumentOutOfRangeException">If the <see cref="Environment"/> value is not null and not one of the <see cref="Plaid.Environment"/> values</exception>
		/// <exception cref="ArgumentNullException">If the <see cref="Environment"/> value is null</exception>
		//public Environment GetEnvironment()
		//{
		//	if (Environment is null) throw new ArgumentNullException(nameof(Environment), "Environment is null in PlaidOptions");
		//	if (!Enum.TryParse<Environment>(Environment, true, out Environment env))
		//	{
		//		throw new ArgumentOutOfRangeException(nameof(Environment), "Invalid Environment value in PlaidOptions. Must be one of Going.Plaid.Environment enum values.");
		//	}
		//	return env;
		//}
	}
}

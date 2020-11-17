using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/link/token/create</c>' endpoint. Used to create a <c>link_token</c>.
	/// </summary>
	public record CreateLinkTokenResponse : ResponseBase
	{
		/// <summary>
		/// The link token returned by Plaid. This should be provided directly to the web client for use with the Link tool.
		/// </summary>
		[JsonPropertyName("link_token")]
		public string LinkToken { get; init; } = null!;

		/// <summary>
		/// The time at which the associated link token expires. After this time, obtain a new link token.
		/// </summary>
		[JsonPropertyName("expiration")]
		public DateTime Expiration { get; init; }
	}
}

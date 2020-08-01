using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/link/token/create</c>' endpoint. Used to create a <c>link_token</c>.
	/// </summary>
	public class CreateLinkTokenResponse : ResponseBase
	{
		/// <summary>
		/// The link token returned by Plaid. This should be provided directly to the web client for use with the Link tool.
		/// </summary>
		[JsonProperty("link_token")]
		public string LinkToken { get; set; } = null!;

		/// <summary>
		/// The time at which the associated link token expires. After this time, obtain a new link token.
		/// </summary>
		[JsonProperty("expiration")]
		public DateTime Expiration { get; set; }
	}
}

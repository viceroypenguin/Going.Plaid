using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Going.Plaid.Options
{
	/// <summary>
	/// 
	/// </summary>
	public class AccountOptions
	{
		/// <summary>
		/// A list of account ids. If provided, the request will be filtered to these accounts.
		/// </summary>
		/// <remarks>An error will be returned if a provided <c>account_id</c> is not associated with the <see cref="Entity.Item"/>.</remarks>
		[JsonPropertyName("account_ids")]
		public string[] AccountIds { get; set; } = null!;
	}
}

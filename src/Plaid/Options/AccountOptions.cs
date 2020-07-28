using System;
using System.Collections.Generic;
using System.Text;

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
		/// <remarks>An error will be returned if a provided account_id is not associated with the <see cref="Entity.Item"/>.</remarks>
		public string[] AccountIds { get; set; } = null!;
	}
}

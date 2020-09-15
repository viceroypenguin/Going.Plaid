using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents which type of webhook is being delivered.
	/// </summary>
	public enum WebhookType
	{
		/// <summary>
		/// When an Automated microdeposit Item is created, Plaid verifies the Item and sends a webhook upon successful verification, 1 to 2 business days later. 
		/// Occasionally when verification does not succeed, Plaid sends an expired webhook.
		/// </summary>
		[EnumMember(Value = "AUTH")]
		Auth,

		/// <summary>
		/// Fired whenever there are new transactions associated with an Item, 
		/// including when Plaid’s initial and historical transaction pull are completed. 
		/// </summary>
		[EnumMember(Value = "TRANSACTIONS")]
		Transactions,
	}
}

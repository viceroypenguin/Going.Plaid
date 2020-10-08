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
		/// Webhooks are used to communicate changes to an Item, such as an updated webhook, 
		/// or errors encountered with an Item. The error typically requires user action to 
		/// resolve, such as when a user changes their password.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/api/webhooks/#item-webhooks"/></remarks>
		[EnumMember(Value = "ITEM")]
		Item,

		/// <summary>
		/// When an Automated microdeposit Item is created, Plaid verifies the Item and sends 
		/// a webhook upon successful verification, 1 to 2 business days later. 
		/// Occasionally when verification does not succeed, Plaid sends an expired webhook.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/api/webhooks/#auth-webhooks"/></remarks>
		[EnumMember(Value = "AUTH")]
		Auth,

		/// <summary>
		/// Fired whenever there are new transactions associated with an Item, 
		/// including when Plaid’s initial and historical transaction pull are completed. 
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/api/webhooks/#transaction-webhooks"/></remarks>
		[EnumMember(Value = "TRANSACTIONS")]
		Transactions,

		/// <summary>
		/// Fired when new or updated holdings have been detected on an investment account. 
		/// The webhook typically fires once per day, after market close, in response to any 
		/// newly added holdings or price changes to existing holdings.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/api/webhooks/#holdings-default_update"/></remarks>
		[EnumMember(Value = "HOLDINGS")]
		Holdings,

		/// <summary>
		/// Fired when new or canceled transactions have been detected on an investment account.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/api/webhooks/#investments_transactions-default_update"/></remarks>
		[EnumMember(Value = "INVESTMENTS_TRANSACTIONS")]
		InvestmentTransactions,
	}
}

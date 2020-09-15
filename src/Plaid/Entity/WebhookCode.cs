using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents additional information about the webhook payload
	/// </summary>
	public enum WebhookCode
	{
		/// <summary>
		/// Used whenever there is an error that must be communicated via the webhook
		/// </summary>
		[EnumMember(Value = "ERROR")]
		Error,

		#region Auth codes
		/// <summary>
		/// Fired when an Item is automatically verified after 1 to 2 business days. 
		/// We recommend communicating to your users when this event is received to 
		/// notify them that their account is verified and ready for use.
		/// </summary>
		[EnumMember(Value = "AUTOMATICALLY_VERIFIED")]
		AutomaticallyVerified,

		/// <summary>
		/// Fired when an Item cannot be verified automatically after 7 days.
		/// </summary>
		[EnumMember(Value = "VERIFICATION_EXPIRED")]
		VerificationExpired,
		#endregion

		#region TRANSACTIONS codes
		/// <summary>
		/// Fired when an Item's initial transaction pull is completed.
		/// </summary>
		/// <remarks>The default pull is 30 days.</remarks>
		[EnumMember(Value = "INITIAL_UPDATE")]
		InitialUpdate,

		/// <summary>
		/// Fired when an Item's historical transaction pull is completed. 
		/// Plaid fetches as much data as is available from the financial institution.
		/// </summary>
		[EnumMember(Value = "HISTORICAL_UPDATE")]
		HistoricalUpdate,

		/// <summary>
		/// Fired when new transaction data is available as Plaid performs its regular updates of the Item.
		/// </summary>
		[EnumMember(Value = "DEFAULT_UPDATE")]
		DefaultUpdate,

		/// <summary>
		/// Fired when transaction(s) for an Item are deleted.
		/// The deleted transaction IDs are included in the webhook payload.
		/// </summary>
		[EnumMember(Value = "TRANSACTIONS_REMOVED")]
		TransactionsRemoved,
		#endregion
	}
}

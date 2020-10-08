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
		#region Common Codes
		/// <summary>
		/// Fired when an error is encountered with an <see cref="Item"/>.
		/// </summary>
		[EnumMember(Value = "ERROR")]
		Error,

		/// <summary>
		/// Fired when new transaction data is available for an <see cref="Item"/>.
		/// This can be triggered for <see cref="WebhookType.Transactions"/>, 
		/// <see cref="WebhookType.Holdings"/>, or <see cref="WebhookType.InvestmentTransactions"/>.
		/// </summary>
		[EnumMember(Value = "DEFAULT_UPDATE")]
		DefaultUpdate,
		#endregion

		#region ITEM Codes
		/// <summary>
		/// Fired when an Item’s access consent is expiring in 7 days. Some <see cref="Item"/>s have 
		/// explicit expiration times and we try to relay this when possible to reduce 
		/// service disruption. This can be resolved by having the user go through Link’s update mode.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/api/webhooks/#item-pending_expiration"/></remarks>
		[EnumMember(Value = "PENDING_EXPIRATION")]
		PendingExpiration,

		/// <summary>
		/// The <see cref="UserPermissionRevoked"/> webhook is fired to when an end user 
		/// has used the my.plaid.com portal to revoke the permission that they previously 
		/// granted to access an <see cref="Item"/>. Once access to an <see cref="Item"/> 
		/// has been revoked, it cannot be restored. If the user subsequently returns to your
		/// application, a new <see cref="Item"/> must be created for the user.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/api/webhooks/#item-user_permission_revoked"/></remarks>
		[EnumMember(Value = "USER_PERMISSION_REVOKED")]
		UserPermissionRevoked,

		/// <summary>
		/// Fired when an <see cref="Item"/>'s webhook is updated. This will be sent to the 
		/// newly specified webhook.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/api/webhooks/#item-webhook_update_acknowledged"/></remarks>
		[EnumMember(Value = "WEBHOOK_UPDATE_ACKNOWLEDGED")]
		WebhookUpdatedAcknowledged,
		#endregion

		#region AUTH Codes
		/// <summary>
		/// Fired when an <see cref="Item"/> is verified via micro-deposits. We recommend
		/// communicating to your users when this event is received to notify them that 
		/// their account is verified and ready for use.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/api/webhooks/#auth-automatically_verified"/></remarks>
		[EnumMember(Value = "AUTOMATICALLY_VERIFIED")]
		AutomaticallyVerified,

		/// <summary>
		/// Fired when an <see cref="Item"/> was not verified via micro-deposits after 
		/// seven days since the micro-deposit was made.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/api/webhooks/#auth-verification_expired"/></remarks>
		[EnumMember(Value = "VERIFICATION_EXPIRED")]
		VerificationExpired,
		#endregion

		#region TRANSACTIONS Codes
		/// <summary>
		/// Fired when an <see cref="Item"/>'s initial transaction pull is completed.
		/// Once this webhook has been fired, transaction data for the most recent 30 days 
		/// can be fetched for the <see cref="Item"/>.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/api/webhooks/#transactions-initial_update"/></remarks>
		[EnumMember(Value = "INITIAL_UPDATE")]
		InitialUpdate,

		/// <summary>
		/// Fired when an <see cref="Item"/>'s historical transaction pull is completed and Plaid has 
		/// prepared as much historical transaction data as possible for the Item. Once 
		/// this webhook has been fired, transaction data beyond the most recent 30 days 
		/// can be fetched for the <see cref="Item"/>.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/api/webhooks/#transactions-historical_update"/></remarks>
		[EnumMember(Value = "HISTORICAL_UPDATE")]
		HistoricalUpdate,

		/// <summary>
		/// Fired when transaction(s) for an <see cref="Item"/> are deleted. The deleted transaction 
		/// IDs are included in the webhook payload. Plaid will typically check for deleted 
		/// transaction data several times a day.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/api/webhooks/#transactions-transactions_removed"/></remarks>
		[EnumMember(Value = "TRANSACTIONS_REMOVED")]
		TransactionsRemoved,
		#endregion

		#region HOLDINGS Codes
		#endregion

		#region INVESTMENTS_TRANSACTIONS Codes
		#endregion
	}
}

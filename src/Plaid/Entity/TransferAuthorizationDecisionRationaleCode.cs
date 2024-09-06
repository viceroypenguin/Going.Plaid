namespace Going.Plaid.Entity;

/// <summary>
/// <para>A code representing the rationale for approving or declining the proposed transfer.</para>
/// </summary>
public enum TransferAuthorizationDecisionRationaleCode
{
	/// <summary>
	/// <para>– Transaction likely to result in a return due to insufficient funds.</para>
	/// </summary>
	[EnumMember(Value = "NSF")]
	Nsf,

	/// <summary>
	/// <para>Transaction is high-risk.</para>
	/// </summary>
	[EnumMember(Value = "RISK")]
	Risk,

	/// <summary>
	/// <para>One or several transfer limits are reached, e.g. monthly transfer limit. Check the accompanying <c>description</c> field to understand which limit has been reached.</para>
	/// </summary>
	[EnumMember(Value = "TRANSFER_LIMIT_REACHED")]
	TransferLimitReached,

	/// <summary>
	/// <para>– Item created via a manual entry flow (i.e. Same Day Micro-deposit, Instant Micro-deposit, Database Insights, or Database Match), limited information available.</para>
	/// </summary>
	[EnumMember(Value = "MANUALLY_VERIFIED_ITEM")]
	ManuallyVerifiedItem,

	/// <summary>
	/// <para>– Unable to collect the account information due to Item staleness. Can be resolved by using Link and setting <a href="https://plaid.com/docs/api/link/#link-token-create-request-transfer-authorization-id"><c>transfer.authorization_id</c></a> in the request to <c>/link/token/create</c>.</para>
	/// </summary>
	[EnumMember(Value = "ITEM_LOGIN_REQUIRED")]
	ItemLoginRequired,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_PROFILE_LOGIN_REQUIRED")]
	PaymentProfileLoginRequired,

	/// <summary>
	/// <para>– Unable to collect the account information due to an unspecified error.</para>
	/// </summary>
	[EnumMember(Value = "ERROR")]
	Error,

	/// <summary>
	/// <para>Item created via <c>/transfer/migrate_account</c> endpoint, limited information available.</para>
	/// </summary>
	[EnumMember(Value = "MIGRATED_ACCOUNT_ITEM")]
	MigratedAccountItem,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

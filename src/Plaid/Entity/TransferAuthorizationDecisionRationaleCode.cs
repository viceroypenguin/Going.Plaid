namespace Going.Plaid.Entity;

/// <summary>
/// <para>A code representing the rationale for approving or declining the proposed transfer. Possible values are:</para>
/// </summary>
public enum TransferAuthorizationDecisionRationaleCode
{
	/// <summary>
	/// <para>– Transaction likely to result in a return due to insufficient funds. Plaid will offer <c>declined</c> as a transaction decision.</para>
	/// </summary>
	[EnumMember(Value = "NSF")]
	Nsf,

	/// <summary>
	/// <para>Transaction is high-risk. Plaid will offer <c>declined</c> as a transaction decision.</para>
	/// </summary>
	[EnumMember(Value = "RISK")]
	Risk,

	/// <summary>
	/// <para>One or several transfer limits are reached, e.g. monthly transfer limit. Plaid will offer <c>declined</c> as a transaction decision.</para>
	/// </summary>
	[EnumMember(Value = "TRANSFER_LIMIT_REACHED")]
	TransferLimitReached,

	/// <summary>
	/// <para>– Item created via same-day micro deposits, limited information available. Plaid will offer <c>approved</c> as a transaction decision.</para>
	/// </summary>
	[EnumMember(Value = "MANUALLY_VERIFIED_ITEM")]
	ManuallyVerifiedItem,

	/// <summary>
	/// <para>– Unable to collect the account information due to Item staleness. Can be rectified using Link in update mode. Plaid will offer <c>approved</c> as a transaction decision.</para>
	/// </summary>
	[EnumMember(Value = "LOGIN_REQUIRED")]
	LoginRequired,

	/// <summary>
	/// <para>– Unable to collect the account information due to an error. Plaid will offer <c>approved</c> as a transaction decision.</para>
	/// </summary>
	[EnumMember(Value = "ERROR")]
	Error,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
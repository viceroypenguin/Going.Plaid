namespace Going.Plaid.Entity;

/// <summary>
/// <para>A code representing the rationale for permitting or declining the proposed transfer. Possible values are:</para>
/// </summary>
public enum TransferAuthorizationDecisionRationaleCodeEnum
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
	/// <para>– Item created via same-day micro deposits, limited information available. Plaid can only offer <c>permitted</c> as a transaction decision.</para>
	/// </summary>
	[EnumMember(Value = "MANUALLY_VERIFIED_ITEM")]
	ManuallyVerifiedItem,

	/// <summary>
	/// <para>– Unable to collect the account information required for an authorization decision due to Item staleness. Can be rectified using Link update mode.</para>
	/// </summary>
	[EnumMember(Value = "LOGIN_REQUIRED")]
	LoginRequired,

	/// <summary>
	/// <para>– Unable to collect the account information required for an authorization decision due to an error.</para>
	/// </summary>
	[EnumMember(Value = "ERROR")]
	Error,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}
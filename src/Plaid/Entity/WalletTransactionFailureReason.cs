namespace Going.Plaid.Entity;

/// <summary>
/// <para>The error code of a failed transaction. Error codes include:</para>
/// </summary>
public enum WalletTransactionFailureReason
{
	/// <summary>
	/// <para>The transaction was declined by an external system.</para>
	/// </summary>
	[EnumMember(Value = "EXTERNAL_SYSTEM")]
	ExternalSystem,

	/// <summary>
	/// <para>The transaction request has expired.</para>
	/// </summary>
	[EnumMember(Value = "EXPIRED")]
	Expired,

	/// <summary>
	/// <para>The transaction request was rescinded.</para>
	/// </summary>
	[EnumMember(Value = "CANCELLED")]
	Cancelled,

	/// <summary>
	/// <para>The transaction did not meet certain criteria, such as an inactive account or no valid counterparty, etc.</para>
	/// </summary>
	[EnumMember(Value = "INVALID")]
	Invalid,

	/// <summary>
	/// <para>The transaction was unsuccessful, but the exact cause is unknown.</para>
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
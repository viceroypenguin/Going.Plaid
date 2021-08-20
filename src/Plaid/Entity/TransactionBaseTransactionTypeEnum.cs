namespace Going.Plaid.Entity;

/// <summary>
/// <para>Please use the <c>payment_channel</c> field, <c>transaction_type</c> will be deprecated in the future.</para>
/// </summary>
public enum TransactionBaseTransactionTypeEnum
{
	/// <summary>
	/// <para>transactions that took place online.</para>
	/// </summary>
	[EnumMember(Value = "digital")]
	Digital,

	/// <summary>
	/// <para>transactions that were made at a physical location.</para>
	/// </summary>
	[EnumMember(Value = "place")]
	Place,

	/// <summary>
	/// <para>transactions that relate to banks, e.g. fees or deposits.</para>
	/// </summary>
	[EnumMember(Value = "special")]
	Special,

	/// <summary>
	/// <para>transactions that do not fit into the other three types.</para>
	/// </summary>
	[EnumMember(Value = "unresolved")]
	Unresolved,
}
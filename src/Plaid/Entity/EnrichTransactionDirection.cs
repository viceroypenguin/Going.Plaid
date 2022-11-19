namespace Going.Plaid.Entity;

/// <summary>
/// <para>The direction of the transaction from the perspective of the account holder:</para>
/// </summary>
public enum EnrichTransactionDirection
{
	/// <summary>
	/// <para>Includes incoming transfers, refunds, and income. (Typically represented as a positive value on checking accounts and debit cards and a negative value on credit cards.)</para>
	/// </summary>
	[EnumMember(Value = "INFLOW")]
	Inflow,

	/// <summary>
	/// <para>Includes outgoing transfers, purchases, and fees. (Typically represented as a negative value on checking accounts and debit cards and a positive value on credit cards.)</para>
	/// </summary>
	[EnumMember(Value = "OUTFLOW")]
	Outflow,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
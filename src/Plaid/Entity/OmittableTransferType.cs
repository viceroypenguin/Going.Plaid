namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of transfer. Valid values are <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account. This field is omitted for Plaid Ledger Sweep events.</para>
/// </summary>
public enum OmittableTransferType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "debit")]
	Debit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "credit")]
	Credit,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

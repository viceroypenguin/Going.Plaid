namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of bank transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.</para>
/// </summary>
public enum BankTransferType
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
}
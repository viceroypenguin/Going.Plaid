namespace Going.Plaid.Entity;

/// <summary>
/// <para>Asset Transaction Type.</para>
/// </summary>
public enum AssetTransactionType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Credit")]
	Credit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Debit")]
	Debit,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

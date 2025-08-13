namespace Going.Plaid.Entity;

/// <summary>
/// <para>Asset Investment Transaction Type Enumerated derived by Vendor.</para>
/// </summary>
public enum AssetInvestmentTransactionType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Buy")]
	Buy,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Sell")]
	Sell,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Dividends")]
	Dividends,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Interest")]
	Interest,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Transfers")]
	Transfers,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Reinvestments")]
	Reinvestments,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FundsReceived")]
	Fundsreceived,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Other")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

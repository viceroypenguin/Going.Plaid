namespace Going.Plaid.Entity;

/// <summary>
/// <para>A value from a MISMO prescribed list that specifies financial assets in a mortgage loan transaction. Assets may be either liquid or fixed and are associated with a corresponding asset amount.</para>
/// </summary>
public enum AssetType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CheckingAccount")]
	Checkingaccount,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SavingsAccount")]
	Savingsaccount,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Investment")]
	Investment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MoneyMarketFund")]
	Moneymarketfund,

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
namespace Going.Plaid.Entity;

/// <summary>
/// <para>The general type of an account.</para>
/// </summary>
public enum AccountType
{
	/// <summary>
	/// <para>An account type holding cash, in which funds are deposited. Supported products for <c>depository</c> accounts are: Auth (<c>checking</c> and <c>savings</c> types only), Balance, Transactions, Identity, Payment Initiation, and Assets.</para>
	/// </summary>
	[EnumMember(Value = "depository")]
	Depository,

	/// <summary>
	/// <para>A credit card type account. Supported products for <c>credit</c> accounts are: Balance, Transactions, Identity, and Liabilities.</para>
	/// </summary>
	[EnumMember(Value = "credit")]
	Credit,

	/// <summary>
	/// <para>A loan type account. Supported products for <c>loan</c> accounts are: Balance, Liabilities, and Transactions.</para>
	/// </summary>
	[EnumMember(Value = "loan")]
	Loan,

	/// <summary>
	/// <para>An investment account. Supported products for <c>investment</c> accounts are: Balance and Investments. In API versions 2018-05-22 and earlier, this type is called <c>brokerage</c>.</para>
	/// </summary>
	[EnumMember(Value = "investment")]
	Investment,

	/// <summary>
	/// <para>An investment account. Used for <c>/assets/</c> endpoints only; other endpoints use <c>investment</c>.</para>
	/// </summary>
	[EnumMember(Value = "brokerage")]
	Brokerage,

	/// <summary>
	/// <para>Other or unknown account type. Supported products for <c>other</c> accounts are: Balance, Transactions, Identity, and Assets.</para>
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
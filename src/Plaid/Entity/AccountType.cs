namespace Going.Plaid.Entity;

/// <summary>
/// <para>The general type of an account.</para>
/// </summary>
public enum AccountType
{
	/// <summary>
	/// <para>An account type holding cash, in which funds are deposited.</para>
	/// </summary>
	[EnumMember(Value = "depository")]
	Depository,

	/// <summary>
	/// <para>A credit card type account.</para>
	/// </summary>
	[EnumMember(Value = "credit")]
	Credit,

	/// <summary>
	/// <para>A loan type account.</para>
	/// </summary>
	[EnumMember(Value = "loan")]
	Loan,

	/// <summary>
	/// <para>An investment account. In API versions 2018-05-22 and earlier, this type is called <c>brokerage</c>.</para>
	/// </summary>
	[EnumMember(Value = "investment")]
	Investment,

	/// <summary>
	/// <para>Other or unknown account type.</para>
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

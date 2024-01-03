namespace Going.Plaid.Entity;

/// <summary>
/// <para>Valid account subtypes for depository accounts. For a list containing descriptions of each subtype, see <a href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-depository">Account schemas</a>.</para>
/// </summary>
public enum DepositoryAccountSubtype
{
	/// <summary>
	/// <para>Checking account</para>
	/// </summary>
	[EnumMember(Value = "checking")]
	Checking,

	/// <summary>
	/// <para>Savings account</para>
	/// </summary>
	[EnumMember(Value = "savings")]
	Savings,

	/// <summary>
	/// <para>Health Savings Account (US only) that can only hold cash</para>
	/// </summary>
	[EnumMember(Value = "hsa")]
	Hsa,

	/// <summary>
	/// <para>Certificate of deposit account</para>
	/// </summary>
	[EnumMember(Value = "cd")]
	Cd,

	/// <summary>
	/// <para>Money market account</para>
	/// </summary>
	[EnumMember(Value = "money market")]
	MoneyMarket,

	/// <summary>
	/// <para>PayPal depository account</para>
	/// </summary>
	[EnumMember(Value = "paypal")]
	Paypal,

	/// <summary>
	/// <para>Prepaid debit card</para>
	/// </summary>
	[EnumMember(Value = "prepaid")]
	Prepaid,

	/// <summary>
	/// <para>A cash management account, typically a cash account at a brokerage</para>
	/// </summary>
	[EnumMember(Value = "cash management")]
	CashManagement,

	/// <summary>
	/// <para>An Electronic Benefit Transfer (EBT) account, used by certain public assistance programs to distribute funds (US only)</para>
	/// </summary>
	[EnumMember(Value = "ebt")]
	Ebt,

	/// <summary>
	/// <para>Allow all of the above subtypes</para>
	/// </summary>
	[EnumMember(Value = "all")]
	All,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

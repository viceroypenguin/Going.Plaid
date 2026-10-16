namespace Going.Plaid.Entity;

/// <summary>
/// <para>Valid account subtypes for loan accounts. For a list containing descriptions of each subtype, see <a href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-loan">Account schemas</a>.</para>
/// </summary>
public enum LoanAccountSubtype
{
	/// <summary>
	/// <para>Auto loan</para>
	/// </summary>
	[EnumMember(Value = "auto")]
	Auto,

	/// <summary>
	/// <para>Business loan</para>
	/// </summary>
	[EnumMember(Value = "business")]
	Business,

	/// <summary>
	/// <para>Commercial loan</para>
	/// </summary>
	[EnumMember(Value = "commercial")]
	Commercial,

	/// <summary>
	/// <para>Commercial line of credit. This subtype is normalized to `line of credit` in plaid-go versions earlier than 10.1.0, plaid-java versions earlier than 44.0.0, plaid-python versions earlier than 8.3.0, and plaid-ruby versions earlier than 14.4.0.</para>
	/// </summary>
	[EnumMember(Value = "commercial line of credit")]
	CommercialLineOfCredit,

	/// <summary>
	/// <para>Construction loan</para>
	/// </summary>
	[EnumMember(Value = "construction")]
	Construction,

	/// <summary>
	/// <para>Consumer loan</para>
	/// </summary>
	[EnumMember(Value = "consumer")]
	Consumer,

	/// <summary>
	/// <para>Home Equity Line of Credit (HELOC)</para>
	/// </summary>
	[EnumMember(Value = "home equity")]
	HomeEquity,

	/// <summary>
	/// <para>Home equity loan. This subtype is normalized to `loan` in plaid-go versions earlier than 10.1.0, plaid-java versions earlier than 44.0.0, plaid-python versions earlier than 8.3.0, and plaid-ruby versions earlier than 14.4.0.</para>
	/// </summary>
	[EnumMember(Value = "home equity loan")]
	HomeEquityLoan,

	/// <summary>
	/// <para>General loan</para>
	/// </summary>
	[EnumMember(Value = "loan")]
	Loan,

	/// <summary>
	/// <para>Mortgage loan</para>
	/// </summary>
	[EnumMember(Value = "mortgage")]
	Mortgage,

	/// <summary>
	/// <para>Pre-approved overdraft account, usually tied to a checking account</para>
	/// </summary>
	[EnumMember(Value = "overdraft")]
	Overdraft,

	/// <summary>
	/// <para>Pre-approved line of credit</para>
	/// </summary>
	[EnumMember(Value = "line of credit")]
	LineOfCredit,

	/// <summary>
	/// <para>Student loan</para>
	/// </summary>
	[EnumMember(Value = "student")]
	Student,

	/// <summary>
	/// <para>Other loan type or unknown loan type</para>
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

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

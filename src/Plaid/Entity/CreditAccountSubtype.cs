namespace Going.Plaid.Entity;

/// <summary>
/// <para>Valid account subtypes for credit accounts. For a list containing descriptions of each subtype, see <a href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-credit">Account schemas</a>.</para>
/// </summary>
public enum CreditAccountSubtype
{
	/// <summary>
	/// <para>Bank-issued credit card</para>
	/// </summary>
	[EnumMember(Value = "credit card")]
	CreditCard,

	/// <summary>
	/// <para>PayPal-issued credit card</para>
	/// </summary>
	[EnumMember(Value = "paypal")]
	Paypal,

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

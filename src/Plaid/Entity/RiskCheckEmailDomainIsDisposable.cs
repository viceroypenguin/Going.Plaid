namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates whether the email domain is listed as disposable if known. Disposable domains are often used to create email addresses that are part of a fake set of user details.</para>
/// </summary>
public enum RiskCheckEmailDomainIsDisposable
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "yes")]
	Yes,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "no")]
	No,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

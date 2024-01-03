namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates whether the email address top level domain, which is the last part of the domain, is fraudulent or risky if known. In most cases, a suspicious top level domain is also associated with a disposable or high-risk domain.</para>
/// </summary>
public enum RiskCheckEmailTopLevelDomainIsSuspicious
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

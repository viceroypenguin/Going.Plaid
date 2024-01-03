namespace Going.Plaid.Entity;

/// <summary>
/// <para>SMTP-MX check to confirm the email address exists if known.</para>
/// </summary>
public enum RiskCheckEmailIsDeliverableStatus
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

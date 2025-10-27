namespace Going.Plaid.Entity;

/// <summary>
/// <para>The confidence level of the incident report.</para>
/// </summary>
public enum ProtectReportConfidence
{
	/// <summary>
	/// <para>indicates the incident has been verified and definitively occurred.</para>
	/// </summary>
	[EnumMember(Value = "CONFIRMED")]
	Confirmed,

	/// <summary>
	/// <para>indicates the incident is believed to have occurred but has not been fully verified.</para>
	/// </summary>
	[EnumMember(Value = "SUSPECTED")]
	Suspected,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

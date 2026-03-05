namespace Going.Plaid.Entity;

/// <summary>
/// <para>The credit bureau that provided the base FICO score.</para>
/// </summary>
public enum CraPartnerInsightsBureau
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EQUIFAX")]
	Equifax,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EXPERIAN")]
	Experian,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSUNION")]
	Transunion,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

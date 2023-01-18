namespace Going.Plaid.Entity;

/// <summary>
/// <para>When set to VERIFICATION_OF_EMPLOYMENT and the Asset Report is added to an Audit Copy Token, the Asset Report will be retrieved by Freddie Mac in the Verification Of Employment (VOE) version instead of the default Verification Of Assets (VOA) version.</para>
/// </summary>
public enum FreddieReportType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_OF_EMPLOYMENT")]
	VerificationOfEmployment,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
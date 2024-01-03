namespace Going.Plaid.Entity;

/// <summary>
/// <para>The confidence that Plaid can support the user in the digital income verification flow instead of requiring a manual paystub upload. One of the following:</para>
/// </summary>
public enum IncomeVerificationPrecheckConfidence
{
	/// <summary>
	/// <para>It is very likely that this user can use the digital income verification flow.</para>
	/// </summary>
	[EnumMember(Value = "HIGH")]
	High,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LOW")]
	Low,

	/// <summary>
	/// <para>It was not possible to determine if the user is supportable with the information passed.</para>
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

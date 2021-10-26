namespace Going.Plaid.Entity;

/// <summary>
/// <para>The confidence that Plaid can support the user in the income verification flow. One of the following:</para>
/// </summary>
public enum IncomeVerificationPrecheckResponseConfidenceEnum
{
	/// <summary>
	/// <para>This precheck information submitted is definitively tied to a Plaid-supported integration.</para>
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
	[EnumMember(Value = "unknown")]
	Unknown,
}
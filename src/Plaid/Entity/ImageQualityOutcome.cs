namespace Going.Plaid.Entity;

/// <summary>
/// <para>The outcome of the image quality check.</para>
/// </summary>
public enum ImageQualityOutcome
{
	/// <summary>
	/// <para>The check passed.</para>
	/// </summary>
	[EnumMember(Value = "success")]
	Success,

	/// <summary>
	/// <para>The check did not pass.</para>
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

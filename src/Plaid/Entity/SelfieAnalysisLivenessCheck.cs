namespace Going.Plaid.Entity;

/// <summary>
/// <para>Assessment of whether the selfie capture is of a real human being, as opposed to a picture of a human on a screen, a picture of a paper cut out, someone wearing a mask, or a deepfake.</para>
/// </summary>
public enum SelfieAnalysisLivenessCheck
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "success")]
	Success,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

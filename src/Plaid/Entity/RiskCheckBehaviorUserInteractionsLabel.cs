namespace Going.Plaid.Entity;

/// <summary>
/// <para>Field describing the overall user interaction signals of a behavior risk check. This value represents how familiar the user is with the personal data they provide, based on a number of signals that are collected during their session.</para>
/// </summary>
public enum RiskCheckBehaviorUserInteractionsLabel
{
	/// <summary>
	/// <para>indicates the user has high familiarity with the data they are providing, and that fraud is unlikely.</para>
	/// </summary>
	[EnumMember(Value = "genuine")]
	Genuine,

	/// <summary>
	/// <para>indicates some signals are present in between <c>risky</c> and <c>genuine</c>, but there are not enough clear signals to determine an outcome.</para>
	/// </summary>
	[EnumMember(Value = "neutral")]
	Neutral,

	/// <summary>
	/// <para>indicates the user has low familiarity with the data they are providing, and that fraud is likely.</para>
	/// </summary>
	[EnumMember(Value = "risky")]
	Risky,

	/// <summary>
	/// <para>indicates there is not sufficient information to give an accurate signal.</para>
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
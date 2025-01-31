namespace Going.Plaid.Entity;

/// <summary>
/// <para>The recommendation result for that date.</para>
/// </summary>
public enum RecommendationString
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RECOMMENDED")]
	Recommended,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NOT_RECOMMENDED")]
	NotRecommended,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

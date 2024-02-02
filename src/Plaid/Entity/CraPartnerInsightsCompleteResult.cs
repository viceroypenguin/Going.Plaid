namespace Going.Plaid.Entity;

/// <summary>
/// <para>The result of the partner insights report generation</para>
/// </summary>
public enum CraPartnerInsightsCompleteResult
{
	/// <summary>
	/// <para>All insights in the partner insights report were successfully generated and can be retrieved via <c>/cra/partner_insights/get</c>.</para>
	/// </summary>
	[EnumMember(Value = "SUCCESS")]
	Success,

	/// <summary>
	/// <para>The partner insights report failed to be generated.</para>
	/// </summary>
	[EnumMember(Value = "FAILURE")]
	Failure,

	/// <summary>
	/// <para>Some, but not all, insights in the partner insights report were successfully generated and can be retrieved via <c>/cra/partner_insights/get</c>.</para>
	/// </summary>
	[EnumMember(Value = "PARTIAL_SUCCESS")]
	PartialSuccess,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

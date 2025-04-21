namespace Going.Plaid.Entity;

/// <summary>
/// <para>It is possible for a Check Report product to be returned with missing information. In such cases, the product will contain warning data in the response, indicating why obtaining the owner information failed.</para>
/// </summary>
public record CraReportWarning
{
	/// <summary>
	/// <para>The warning type, which will always be <c>CHECK_REPORT_WARNING</c></para>
	/// </summary>
	[JsonPropertyName("warning_type")]
	public string WarningType { get; init; } = default!;

	/// <summary>
	/// <para>The warning code identifies a specific kind of warning.</para>
	/// </summary>
	[JsonPropertyName("warning_code")]
	public Entity.CheckReportWarningCode WarningCode { get; init; } = default!;

	/// <summary>
	/// <para>An error object and associated <c>item_id</c> used to identify a specific Item and error when a batch operation operating on multiple Items has encountered an error in one of the Items.</para>
	/// </summary>
	[JsonPropertyName("cause")]
	public Entity.Cause? Cause { get; init; } = default!;

}

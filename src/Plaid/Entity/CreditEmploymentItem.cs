namespace Going.Plaid.Entity;

/// <summary>
/// <para>The object containing employment items.</para>
/// </summary>
public record CreditEmploymentItem
{
	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("employments")]
	public IReadOnlyList<Entity.CreditEmploymentVerification> Employments { get; init; } = default!;

	/// <summary>
	/// <para>Token to represent the underlying Employment data</para>
	/// </summary>
	[JsonPropertyName("employment_report_token")]
	public string? EmploymentReportToken { get; init; } = default!;
}
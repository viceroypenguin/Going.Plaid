namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the status of the Monitoring Insights Item and potential reasons in case of non-available statuses</para>
/// </summary>
public record MonitoringInsightsItemStatus
{
	/// <summary>
	/// <para>Enum for the status of the Item's insights</para>
	/// </summary>
	[JsonPropertyName("status_code")]
	public Entity.MonitoringItemStatusCode StatusCode { get; init; } = default!;

	/// <summary>
	/// <para>A reason for why a Monitoring Insights Report is not available.</para>
	/// <para>This field will only be populated when the <c>status_code</c> is not <c>AVAILABLE</c></para>
	/// </summary>
	[JsonPropertyName("reason")]
	public string? Reason { get; init; } = default!;

}
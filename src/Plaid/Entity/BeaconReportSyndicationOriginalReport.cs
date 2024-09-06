namespace Going.Plaid.Entity;

/// <summary>
/// <para>A subset of information from a Beacon Report that has been syndicated to a matching Beacon User in your program.</para>
/// <para>The <c>id</c> field in the response is the ID of the original report that was syndicated. If the original report was created by your organization, the field will be filled with the ID of the report. Otherwise, the field will be <c>null</c> indicating that the original report was created by another Beacon customer.</para>
/// </summary>
public record BeaconReportSyndicationOriginalReport
{
	/// <summary>
	/// <para>ID of the associated Beacon Report.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string? Id { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>The type of Beacon Report.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.BeaconReportType Type { get; init; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("fraud_date")]
	public DateOnly? FraudDate { get; init; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("event_date")]
	public DateOnly EventDate { get; init; } = default!;

}

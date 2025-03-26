namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a Monitoring Insights Item</para>
/// </summary>
public record CraMonitoringInsightsItem
{
	/// <summary>
	/// <para>The date and time when the specific insights were generated (per-item), in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (e.g. "2018-04-12T03:32:11Z").</para>
	/// </summary>
	[JsonPropertyName("date_generated")]
	public DateTimeOffset DateGenerated { get; init; } = default!;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with the insights</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>An object with details of the Monitoring Insights Item's status.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.MonitoringInsightsItemStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the Monitoring Insights for the given Item</para>
	/// </summary>
	[JsonPropertyName("insights")]
	public Entity.MonitoringInsights? Insights { get; init; } = default!;

	/// <summary>
	/// <para>Data about each of the accounts open on the Item.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.BaseReportAccount>? Accounts { get; init; } = default!;

}

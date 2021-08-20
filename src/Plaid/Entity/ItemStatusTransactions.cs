namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the last successful and failed transactions update for the Item.</para>
/// </summary>
public record ItemStatusTransactions
{
	/// <summary>
	/// <para>ISO 8601 timestamp of the last successful transactions update for the Item. The status will update each time Plaid successfully connects with the institution, regardless of whether any new data is available in the update.</para>
	/// </summary>
	[JsonPropertyName("last_successful_update")]
	public DateTimeOffset? LastSuccessfulUpdate { get; init; } = default!;

	/// <summary>
	/// <para>ISO 8601 timestamp of the last failed transactions update for the Item. The status will update each time Plaid fails an attempt to connect with the institution, regardless of whether any new data is available in the update.</para>
	/// </summary>
	[JsonPropertyName("last_failed_update")]
	public DateTimeOffset? LastFailedUpdate { get; init; } = default!;
}
namespace Going.Plaid.Entity;

/// <summary>
/// <para>A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.</para>
/// </summary>
public record ProductStatus
{
	/// <summary>
	/// <para>This field is deprecated in favor of the <c>breakdown</c> object, which provides more granular institution health data.</para>
	/// </summary>
	[JsonPropertyName("status")]
	[Obsolete("Please use the `breakdown` object instead.")]
	public Entity.ProductStatusStatusEnum Status { get; init; } = default!;

	/// <summary>
	/// <para><a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> formatted timestamp of the last status change for the institution.</para>
	/// </summary>
	[JsonPropertyName("last_status_change")]
	public DateTimeOffset LastStatusChange { get; init; } = default!;

	/// <summary>
	/// <para>A detailed breakdown of the institution's performance for a request type. The values for <c>success</c>, <c>error_plaid</c>, and <c>error_institution</c> sum to 1.</para>
	/// </summary>
	[JsonPropertyName("breakdown")]
	public Entity.StatusBreakdown Breakdown { get; init; } = default!;
}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details regarding return rates.</para>
/// </summary>
public record TransferMetricsGetReturnRatesOverInterval
{
	/// <summary>
	/// <para>The overall return rate.</para>
	/// </summary>
	[JsonPropertyName("overall_return_rate")]
	public string? OverallReturnRate { get; init; } = default!;

	/// <summary>
	/// <para>The unauthorized return rate.</para>
	/// </summary>
	[JsonPropertyName("unauthorized_return_rate")]
	public string? UnauthorizedReturnRate { get; init; } = default!;

	/// <summary>
	/// <para>The administrative return rate.</para>
	/// </summary>
	[JsonPropertyName("administrative_return_rate")]
	public string? AdministrativeReturnRate { get; init; } = default!;

}

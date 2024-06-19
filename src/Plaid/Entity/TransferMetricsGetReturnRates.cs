namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details regarding return rates.</para>
/// </summary>
public record TransferMetricsGetReturnRates
{
	/// <summary>
	/// <para>Details regarding return rates.</para>
	/// </summary>
	[JsonPropertyName("last_60d")]
	public Entity.TransferMetricsGetReturnRatesOverInterval? Last60d { get; init; } = default!;

}

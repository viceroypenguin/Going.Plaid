namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about a fixed income security's expected rate of return.</para>
/// </summary>
public record YieldRate
{
	/// <summary>
	/// <para>The fixed income security's expected rate of return.</para>
	/// </summary>
	[JsonPropertyName("percentage")]
	public decimal Percentage { get; init; } = default!;

	/// <summary>
	/// <para>The type of rate which indicates how the predicted yield was calculated. It is one of:</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.YieldRateType? Type { get; init; } = default!;

}

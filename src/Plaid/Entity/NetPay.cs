namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing information about the net pay amount on the paystub.</para>
/// </summary>
public record NetPay
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("distribution_details")]
	public IReadOnlyList<Entity.DistributionDetails> DistributionDetails { get; init; } = default!;

	/// <summary>
	/// <para>An object representing both the current pay period and year to date amount for a category.</para>
	/// </summary>
	[JsonPropertyName("total")]
	public Entity.Total Total { get; init; } = default!;
}
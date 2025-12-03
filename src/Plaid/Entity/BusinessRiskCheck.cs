namespace Going.Plaid.Entity;

/// <summary>
/// <para>Results from the business risk assessment check</para>
/// </summary>
public record BusinessRiskCheck
{
	/// <summary>
	/// <para>Status of the business risk assessment check</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.BusinessVerificationStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>A score from 0 to 100 indicating the risk assessment for the business</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public record IncomeSummaryFieldNumber
{
	/// <summary>
	/// <para>The value of the field.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public decimal Value { get; init; } = default!;

	/// <summary>
	/// <para>The verification status. One of the following:</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public Entity.VerificationStatus VerificationStatus { get; init; } = default!;
}
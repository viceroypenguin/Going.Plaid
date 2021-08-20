namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public record IncomeSummaryFieldString
{
	/// <summary>
	/// <para>The value of the field.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; init; } = default!;

	/// <summary>
	/// <para>The verification status. One of the following:</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public Entity.VerificationStatus VerificationStatus { get; init; } = default!;
}
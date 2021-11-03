namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing information for whether or not the uploaded paystub is fradulent</para>
/// </summary>
public record PaystubVerification
{
	/// <summary>
	/// <para>Derived verification status.</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public Entity.PaystubVerificationVerificationStatusEnum? VerificationStatus { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("verification_attributes")]
	public IReadOnlyList<Entity.VerificationAttribute> VerificationAttributes { get; init; } = default!;
}
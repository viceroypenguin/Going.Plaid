namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing information for whether or not the uploaded paystub is fradulent</para>
/// </summary>
public record PaystubFraudVerification
{
	/// <summary>
	/// <para>Derived verification status.</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public Entity.PaystubFraudVerificationVerificationStatusEnum? VerificationStatus { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("fraud_attributes")]
	public IReadOnlyList<Entity.FraudAttributes> FraudAttributes { get; init; } = default!;
}
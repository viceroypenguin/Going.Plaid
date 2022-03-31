namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing details on the paystub's verification status. This object will only be populated if the <a href="https://plaid.com/docs/api/tokens/#link-token-create-request-income-verification-access-tokens"><c>income_verification.access_tokens</c></a> parameter was provided during the <c>/link/token/create</c> call or if a problem was detected with the information supplied by the user; otherwise it will be <c>null</c>.</para>
/// </summary>
public record PayStubVerification
{
	/// <summary>
	/// <para>Derived verification status.</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public string? VerificationStatus { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("verification_attributes")]
	public IReadOnlyList<Entity.PayStubVerificationAttribute> VerificationAttributes { get; init; } = default!;
}
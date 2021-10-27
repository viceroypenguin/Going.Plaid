namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationRequestResponse defines the response schema for <c>/income/verification/refresh</c></para>
/// </summary>
public record IncomeVerificationRefreshResponse : ResponseBase
{
	/// <summary>
	/// <para>The verification refresh status. One of the following:</para>
	/// </summary>
	[JsonPropertyName("verification_refresh_status")]
	public Entity.VerificationRefreshStatus VerificationRefreshStatus { get; init; } = default!;
}
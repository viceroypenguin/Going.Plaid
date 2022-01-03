namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationPaystubGetResponse defines the response schema for <c>/income/verification/paystub/get</c>.</para>
/// </summary>
public record IncomeVerificationPaystubGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An object representing data extracted from the end user's paystub.</para>
	/// </summary>
	[JsonPropertyName("paystub")]
	public Entity.Paystub Paystub { get; init; } = default!;
}

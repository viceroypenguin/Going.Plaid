namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationPaystubsGetResponse defines the response schema for <c>/income/verification/paystubs/get</c>.</para>
/// </summary>
public record IncomeVerificationPaystubsGetResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("paystubs")]
	public IReadOnlyList<Entity.Paystub> Paystubs { get; init; } = default!;
}
namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationPaystubsGetResponse defines the response schema for <c>/income/verification/paystubs/get</c>.</para>
/// </summary>
public record IncomeVerificationPaystubsGetResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("document_metadata")]
	public IReadOnlyList<Entity.DocumentMetadata> DocumentMetadata { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("paystubs")]
	public IReadOnlyList<Entity.Paystub> Paystubs { get; init; } = default!;
}

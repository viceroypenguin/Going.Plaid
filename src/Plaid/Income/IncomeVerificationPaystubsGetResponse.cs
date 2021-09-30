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

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be <c>null</c> if no error has occurred.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Exceptions.PlaidException? Error { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("document_metadata")]
	public IReadOnlyList<Entity.DocumentMetadata> DocumentMetadata { get; init; } = default!;
}
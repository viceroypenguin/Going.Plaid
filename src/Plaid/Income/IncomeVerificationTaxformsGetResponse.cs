namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationTaxformsGetResponse defines the response schema for <c>/income/verification/taxforms/get</c></para>
/// </summary>
public record IncomeVerificationTaxformsGetResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("document_metadata")]
	public IReadOnlyList<Entity.DocumentMetadata> DocumentMetadata { get; init; } = default!;

	/// <summary>
	/// <para>A list of forms.</para>
	/// </summary>
	[JsonPropertyName("taxforms")]
	public IReadOnlyList<Entity.Taxform> Taxforms { get; init; } = default!;

}

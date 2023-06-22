namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditBankStatementsUploadsGetResponse defines the response schema for <c>/credit/bank_statements/uploads/get</c></para>
/// </summary>
public record CreditBankStatementsUploadsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Array of bank statement upload items.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CreditBankStatementUploadItem> Items { get; init; } = default!;
}
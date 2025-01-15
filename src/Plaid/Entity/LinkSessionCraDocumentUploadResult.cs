namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of a document upload CRA session in link</para>
/// </summary>
public record LinkSessionCraDocumentUploadResult
{
	/// <summary>
	/// <para>The number of bank statements uploaded by the user.</para>
	/// </summary>
	[JsonPropertyName("num_bank_statements_uploaded")]
	public int NumBankStatementsUploaded { get; init; } = default!;

}

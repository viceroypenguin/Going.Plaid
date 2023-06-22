namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing data that has been parsed from a user-uploaded bank statement.</para>
/// </summary>
public record CreditBankStatementUploadObject
{
	/// <summary>
	/// <para>An array of transactions appearing on the bank statement.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.CreditBankStatementUploadTransaction> Transactions { get; init; } = default!;

	/// <summary>
	/// <para>Object representing metadata pertaining to the document.</para>
	/// </summary>
	[JsonPropertyName("document_metadata")]
	public Entity.CreditDocumentMetadata DocumentMetadata { get; init; } = default!;

	/// <summary>
	/// <para>An identifier of the document referenced by the document metadata.</para>
	/// </summary>
	[JsonPropertyName("document_id")]
	public string? DocumentId { get; init; } = default!;

	/// <summary>
	/// <para>An array of bank accounts associated with the uploaded bank statement.</para>
	/// </summary>
	[JsonPropertyName("bank_accounts")]
	public IReadOnlyList<Entity.CreditBankStatementUploadBankAccount> BankAccounts { get; init; } = default!;
}
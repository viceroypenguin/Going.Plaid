namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing data about the owner of the bank account for the uploaded bank statement.</para>
/// </summary>
public record CreditBankStatementUploadAccountOwner
{
	/// <summary>
	/// <para>The name of the account owner</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>Address on the uploaded bank statement</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.CreditBankStatementUploadAccountOwnerAddress Address { get; init; } = default!;
}
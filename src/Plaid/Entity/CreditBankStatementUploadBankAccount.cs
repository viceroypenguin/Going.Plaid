namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing data about a user's bank account related to an uploaded bank statement.</para>
/// </summary>
public record CreditBankStatementUploadBankAccount
{
	/// <summary>
	/// <para>The name of the bank account</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>The name of the bank institution.</para>
	/// </summary>
	[JsonPropertyName("bank_name")]
	public string? BankName { get; init; } = default!;

	/// <summary>
	/// <para>The type of the bank account.</para>
	/// </summary>
	[JsonPropertyName("account_type")]
	public string? AccountType { get; init; } = default!;

	/// <summary>
	/// <para>The bank account number.</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string? AccountNumber { get; init; } = default!;

	/// <summary>
	/// <para>An object containing data about the owner of the bank account for the uploaded bank statement.</para>
	/// </summary>
	[JsonPropertyName("owner")]
	public Entity.CreditBankStatementUploadAccountOwner Owner { get; init; } = default!;

	/// <summary>
	/// <para>An array of period objects, containing more data on the overall period of the statement.</para>
	/// </summary>
	[JsonPropertyName("periods")]
	public IReadOnlyList<Entity.CreditBankStatementUploadBankAccountPeriod> Periods { get; init; } = default!;

	/// <summary>
	/// <para>The unique id of the bank account</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing data about a transaction appearing on a user-uploaded bank statement.</para>
/// </summary>
public record CreditBankStatementUploadTransaction
{
	/// <summary>
	/// <para>The value of the transaction. A negative amount indicates that money moved into the account (such as a paycheck being deposited).</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal? Amount { get; init; } = default!;

	/// <summary>
	/// <para>The date of when the transaction was made, in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("date")]
	public DateOnly? Date { get; init; } = default!;

	/// <summary>
	/// <para>The raw description of the transaction as it appears on the bank statement.</para>
	/// </summary>
	[JsonPropertyName("original_description")]
	public string? OriginalDescription { get; init; } = default!;

	/// <summary>
	/// <para>The unique id of the bank account that this transaction occurs in</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

}

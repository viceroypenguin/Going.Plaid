namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data to populate as test transaction data.</para>
/// </summary>
public class CustomSandboxTransaction
{
	/// <summary>
	/// <para>The date of the transaction, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> (YYYY-MM-DD) format. Transaction date must be the present date or a date up to 730 days in the past. Future dates are not allowed.</para>
	/// </summary>
	[JsonPropertyName("date_transacted")]
	public DateOnly DateTransacted { get; set; } = default!;

	/// <summary>
	/// <para>The date the transaction posted, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> (YYYY-MM-DD) format. Posted date must be the present date or a date up to 730 days in the past. Future dates are not allowed.</para>
	/// </summary>
	[JsonPropertyName("date_posted")]
	public DateOnly DatePosted { get; set; } = default!;

	/// <summary>
	/// <para>The transaction amount. Can be negative.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; set; } = default!;

	/// <summary>
	/// <para>The transaction description.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; } = default!;

	/// <summary>
	/// <para>The ISO-4217 format currency code for the transaction. Defaults to USD.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>The <c>account_id</c> of the account to add the transaction to, as returned by <c>/accounts/get</c>. If omitted, the transaction is added to the Item's checking account, or, for a custom Sandbox user, to the first depository account listed in its <c>override_accounts</c>, or its first account if it has no depository account. Student loan accounts don't accept custom transactions and return an <c>INVALID_ACCOUNT_ID</c> error.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; set; } = default!;

}

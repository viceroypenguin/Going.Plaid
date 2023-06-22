namespace Going.Plaid.Entity;

/// <summary>
/// <para>A client-provided transaction that Plaid has enriched.</para>
/// </summary>
public record ClientProvidedEnrichedTransaction
{
	/// <summary>
	/// <para>The unique ID for the transaction as provided by you in the request.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>A unique user id used to group transactions for a given user, as a unique identifier from your application. Personally identifiable information, such as an email address or phone number, should not be used in the client_user_id.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; init; } = default!;

	/// <summary>
	/// <para>A unique account id used to group transactions for a given account, as a unique identifier from your application. Personally identifiable information, such as an email address or phone number, should not be used in the client_account_id.</para>
	/// </summary>
	[JsonPropertyName("client_account_id")]
	public string? ClientAccountId { get; init; } = default!;

	/// <summary>
	/// <para>The account type associated with the transaction. For a full list of valid types and subtypes, see the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</a>.</para>
	/// </summary>
	[JsonPropertyName("account_type")]
	public string? AccountType { get; init; } = default!;

	/// <summary>
	/// <para>The account subtype associated with the transaction. For a full list of valid types and subtypes, see the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</a>.</para>
	/// </summary>
	[JsonPropertyName("account_subtype")]
	public string? AccountSubtype { get; init; } = default!;

	/// <summary>
	/// <para>The raw description of the transaction.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// <para>The absolute value of the transaction (>= 0)</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; init; } = default!;

	/// <summary>
	/// <para>The direction of the transaction from the perspective of the account holder:</para>
	/// </summary>
	[JsonPropertyName("direction")]
	public Entity.EnrichTransactionDirection? Direction { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the transaction e.g. USD.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>A grouping of the Plaid produced transaction enrichment fields.</para>
	/// </summary>
	[JsonPropertyName("enrichments")]
	public Entity.Enrichments Enrichments { get; init; } = default!;
}
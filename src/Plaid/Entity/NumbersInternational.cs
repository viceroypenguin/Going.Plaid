namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identifying information for transferring money to or from an international bank account via wire transfer.</para>
/// </summary>
public record NumbersInternational
{
	/// <summary>
	/// <para>The Plaid account ID associated with the account numbers</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The International Bank Account Number (IBAN) for the account</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string Iban { get; init; } = default!;

	/// <summary>
	/// <para>The Bank Identifier Code (BIC) for the account</para>
	/// </summary>
	[JsonPropertyName("bic")]
	public string Bic { get; init; } = default!;
}
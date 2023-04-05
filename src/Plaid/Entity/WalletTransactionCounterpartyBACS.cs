namespace Going.Plaid.Entity;

/// <summary>
/// <para>The account number and sort code of the counterparty's account</para>
/// </summary>
public class WalletTransactionCounterpartyBACS
{
	/// <summary>
	/// <para>The account number of the account. Maximum of 10 characters.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public string? Account { get; set; } = default!;

	/// <summary>
	/// <para>The 6-character sort code of the account.</para>
	/// </summary>
	[JsonPropertyName("sort_code")]
	public string? SortCode { get; set; } = default!;
}
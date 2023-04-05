namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing a BACS account number and sort code. If an IBAN is not provided or if you need to accept domestic GBP-denominated payments, BACS data is required.</para>
/// </summary>
public class RecipientBACS
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
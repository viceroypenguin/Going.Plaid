namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identifying information for transferring money to or from a Canadian bank account via EFT.</para>
/// </summary>
public record NumbersEft
{
	/// <summary>
	/// <para>The Plaid account ID associated with the account numbers</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The EFT account number for the account</para>
	/// </summary>
	[JsonPropertyName("account")]
	public string Account { get; init; } = default!;

	/// <summary>
	/// <para>The EFT institution number for the account</para>
	/// </summary>
	[JsonPropertyName("institution")]
	public string Institution { get; init; } = default!;

	/// <summary>
	/// <para>The EFT branch number for the account</para>
	/// </summary>
	[JsonPropertyName("branch")]
	public string Branch { get; init; } = default!;

}

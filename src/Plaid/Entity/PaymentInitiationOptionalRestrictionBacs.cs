namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object used to restrict the accounts used for payments. If provided, the end user will be able to send payments only from the specified bank account.</para>
/// </summary>
public class PaymentInitiationOptionalRestrictionBacs
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

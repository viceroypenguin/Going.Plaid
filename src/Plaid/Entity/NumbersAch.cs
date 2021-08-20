namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identifying information for transferring money to or from a US account via ACH or wire transfer.</para>
/// </summary>
public record NumbersAch
{
	/// <summary>
	/// <para>The Plaid account ID associated with the account numbers</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The ACH account number for the account.</para>
	/// <para>Note that when using OAuth with Chase Bank (<c>ins_56</c>), Chase will issue "tokenized" routing and account numbers, which are not the user's actual account and routing numbers. These tokenized numbers should work identically to normal account and routing numbers. The digits returned in the mask field will continue to reflect the actual account number, rather than the tokenized account number. If a user revokes their permissions to your app, the tokenized numbers will continue to work for ACH deposits, but not withdrawals.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public string Account { get; init; } = default!;

	/// <summary>
	/// <para>The ACH routing number for the account. If the institution is <c>ins_56</c>, this may be a tokenized routing number. For more information, see the description of the <c>account</c> field.</para>
	/// </summary>
	[JsonPropertyName("routing")]
	public string Routing { get; init; } = default!;

	/// <summary>
	/// <para>The wire transfer routing number for the account, if available</para>
	/// </summary>
	[JsonPropertyName("wire_routing")]
	public string? WireRouting { get; init; } = default!;
}
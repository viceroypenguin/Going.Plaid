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
	/// <para>At certain institutions, including Chase and PNC, you will receive "tokenized" routing and account numbers, which are not the user's actual account and routing numbers. For important details on how this may impact your integration and on how to avoid fraud, user confusion, and ACH returns, see <a href="https://plaid.com/docs/auth/#tokenized-account-numbers">Tokenized account numbers</a>.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public string Account { get; init; } = default!;

	/// <summary>
	/// <para>The ACH routing number for the account. This may be a tokenized routing number. For more information, see <a href="https://plaid.com/docs/auth/#tokenized-account-numbers">Tokenized account numbers</a>.</para>
	/// </summary>
	[JsonPropertyName("routing")]
	public string Routing { get; init; } = default!;

	/// <summary>
	/// <para>The wire transfer routing number for the account, if available</para>
	/// </summary>
	[JsonPropertyName("wire_routing")]
	public string? WireRouting { get; init; } = default!;

	/// <summary>
	/// <para>Whether the account supports ACH transfers into the account</para>
	/// </summary>
	[JsonPropertyName("can_transfer_in")]
	public bool? CanTransferIn { get; init; } = default!;

	/// <summary>
	/// <para>Whether the account supports ACH transfers out of the account</para>
	/// </summary>
	[JsonPropertyName("can_transfer_out")]
	public bool? CanTransferOut { get; init; } = default!;

}

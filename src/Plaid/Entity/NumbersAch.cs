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
	/// <para>Note that when using OAuth with Chase Bank (<c>ins_56</c>), Chase will issue "tokenized" routing and account numbers, which are not the user's actual account and routing numbers. These tokenized account numbers (also known as TANs) should work identically to normal account and routing numbers for ACH and RTP transfers, but are not compatible with wire transfers. The digits returned in the <c>mask</c> field will continue to reflect the actual account number, rather than the tokenized account number; for this reason, when displaying account numbers to the user to help them identify their account in your UI, always use the <c>mask</c> rather than truncating the <c>account</c> number. If a user revokes their permissions to your app, the tokenized numbers will no longer work. To be alerted when this occurs, listen for the <a href="https://plaid.com/docs/api/items/#user_permission_revoked"><c>USER_PERMISSION_REVOKED</c></a> and <a href="https://plaid.com/docs/api/items/#user_account_revoked"><c>USER_ACCOUNT_REVOKED</c></a> webhooks.</para>
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

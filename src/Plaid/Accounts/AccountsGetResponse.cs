namespace Going.Plaid.Accounts;

/// <summary>
/// <para>AccountsGetResponse defines the response schema for <c>/accounts/get</c> and <c>/accounts/balance/get</c>.</para>
/// </summary>
public record AccountsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of financial institution accounts associated with the Item.</para>
	/// <para>If <c>/accounts/balance/get</c> was called, each account will include real-time balance information.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.Account> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;
}
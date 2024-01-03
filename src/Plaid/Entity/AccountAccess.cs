namespace Going.Plaid.Entity;

/// <summary>
/// <para>Allow or disallow product access by account. Unlisted (e.g. missing) accounts will be considered <c>new_accounts</c>.</para>
/// </summary>
public record AccountAccess
{
	/// <summary>
	/// <para>The unique account identifier for this account. This value must match that returned by the data access API for this account.</para>
	/// </summary>
	[JsonPropertyName("unique_id")]
	public string UniqueId { get; init; } = default!;

	/// <summary>
	/// <para>Allow the application to see this account (and associated details, including balance) in the list of accounts  If unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("authorized")]
	public bool? Authorized { get; init; } = default!;

	/// <summary>
	/// <para>Allow the application to access specific products on this account</para>
	/// </summary>
	[JsonPropertyName("account_product_access")]
	public Entity.AccountProductAccess? AccountProductAccess { get; init; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>The scopes object</para>
/// </summary>
public class Scopes
{
	/// <summary>
	/// <para>The product access being requested. Used to or disallow product access across all accounts. If unset, defaults to all products allowed.</para>
	/// </summary>
	[JsonPropertyName("product_access")]
	public Entity.ProductAccess? ProductAccess { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.AccountAccess>? Accounts { get; set; } = default!;

	/// <summary>
	/// <para>Allow access to newly opened accounts as they are opened. If unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("new_accounts")]
	public bool? NewAccounts { get; set; } = default!;
}
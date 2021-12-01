namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public record AccountIdentity : Entity.Account
{
	/// <summary>
	/// <para>Data returned by the financial institution about the account owner or owners. Only returned by Identity or Assets endpoints. Multiple owners on a single account will be represented in the same <c>owner</c> object, not in multiple owner objects within the array. In API versions 2018-05-22 and earlier, the <c>owners</c> object is not returned, and instead identity information is returned in the top level <c>identity</c> object. For more details, see <a href="https://plaid.com/docs/api/versioning/#version-2019-05-29">Plaid API versioning</a></para>
	/// </summary>
	[JsonPropertyName("owners")]
	public IReadOnlyList<Entity.Owner> Owners { get; init; } = default!;
}
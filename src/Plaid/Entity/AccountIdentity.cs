namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public record AccountIdentity : Entity.Account
{
	/// <summary>
	/// <para>Data returned by the financial institution about the account owner or owners. Only returned by Identity or Assets endpoints. Multiple owners on a single account will be represented in the same <c>owner</c> object, not in multiple owner objects within the array.</para>
	/// </summary>
	[JsonPropertyName("owners")]
	public IReadOnlyList<Entity.Owner> Owners { get; init; } = default!;
}
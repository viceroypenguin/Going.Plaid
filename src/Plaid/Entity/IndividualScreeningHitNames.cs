namespace Going.Plaid.Entity;

/// <summary>
/// <para>Name information for the associated individual watchlist hit</para>
/// </summary>
public record IndividualScreeningHitNames
{
	/// <summary>
	/// <para>The full name of the individual, including all parts.</para>
	/// </summary>
	[JsonPropertyName("full")]
	public string Full { get; init; } = default!;

	/// <summary>
	/// <para>Primary names are those most commonly used to refer to this person. Only one name will ever be marked as primary.</para>
	/// </summary>
	[JsonPropertyName("is_primary")]
	public bool IsPrimary { get; init; } = default!;

	/// <summary>
	/// <para>Names that are explicitly marked as low quality either by their <c>source</c> list, or by <c>plaid</c> by a series of additional checks done by Plaid. Plaid does not ever surface a hit as a result of a weak name alone. If a name has no quality issues, this value will be <c>none</c>.</para>
	/// </summary>
	[JsonPropertyName("weak_alias_determination")]
	public Entity.WeakAliasDetermination WeakAliasDetermination { get; init; } = default!;

}

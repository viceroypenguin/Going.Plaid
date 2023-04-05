namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of an Item add in Link.</para>
/// </summary>
public record CreditSessionItemAddResult
{
	/// <summary>
	/// <para>Returned once a user has successfully linked their Item.</para>
	/// </summary>
	[JsonPropertyName("public_token")]
	public string? PublicToken { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid Institution ID associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;
}
namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of an Item add in Link.</para>
/// </summary>
public record LinkSessionItemAddResult
{
	/// <summary>
	/// <para>Returned once a user has successfully linked their Item.</para>
	/// </summary>
	[JsonPropertyName("public_token")]
	public string PublicToken { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>An institution object. If the Item was created via Same-Day or Instant micro-deposit verification, will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("institution")]
	public Entity.LinkSessionSuccessMetadataInstitution? Institution { get; init; } = default!;

}

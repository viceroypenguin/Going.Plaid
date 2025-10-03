namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of a Plaid Check Item update via Update Mode in Link.</para>
/// </summary>
public record LinkSessionCraUpdateResult
{
	/// <summary>
	/// <para>The Plaid Check Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. The <c>item_id</c> is case-sensitive.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>A list of accounts attached to the connected Item. If Account Select is enabled via the developer dashboard, <c>accounts</c> will only include selected accounts.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.LinkSessionSuccessMetadataAccount> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>An institution object. If the Item was created via Same-Day or Instant micro-deposit verification, will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("institution")]
	public Entity.LinkSessionSuccessMetadataInstitution? Institution { get; init; } = default!;

}

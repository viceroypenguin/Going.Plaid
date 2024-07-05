namespace Going.Plaid.Entity;

/// <summary>
/// <para>A collection of Bank Accounts linked to an Item that is associated with this Beacon User.</para>
/// </summary>
public record BeaconBankAccounts
{
	/// <summary>
	/// <para>The Plaid Item ID the Bank Accounts belong to.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.BeaconBankAccountInsights> Accounts { get; init; } = default!;

}

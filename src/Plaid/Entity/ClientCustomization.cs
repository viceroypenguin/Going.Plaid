namespace Going.Plaid.Entity;

/// <summary>
/// <para>Custom client fields</para>
/// </summary>
public record ClientCustomization
{
	/// <summary>
	/// <para>Custom entity ID that maps to a merchant or counterparty. This is different from the <c>merchant_entity_id</c> as well as the <c>entity_id</c> on the counterparties object to meet client specific needs.</para>
	/// </summary>
	[JsonPropertyName("custom_entity_id")]
	public string? CustomEntityId { get; init; } = default!;

}

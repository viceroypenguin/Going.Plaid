namespace Going.Plaid.Entity;

/// <summary>
/// <para>The counterparty, such as the merchant or financial institution, is extracted by Plaid from the raw description.</para>
/// </summary>
public record Counterparty
{
	/// <summary>
	/// <para>The name of the counterparty, such as the merchant or the financial institution, as extracted by Plaid from the raw description.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The counterparty type.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.CounterpartyType Type { get; init; } = default!;
}
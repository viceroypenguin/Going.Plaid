namespace Going.Plaid.Liabilities;

/// <summary>
/// <para>LiabilitiesGetResponse defines the response schema for <c>/liabilities/get</c></para>
/// </summary>
public record LiabilitiesGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of accounts associated with the Item</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.Account> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

	/// <summary>
	/// <para>An object containing liability accounts</para>
	/// </summary>
	[JsonPropertyName("liabilities")]
	public Entity.LiabilitiesObject Liabilities { get; init; } = default!;

}

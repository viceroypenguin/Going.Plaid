namespace Going.Plaid.Investments;

/// <summary>
/// <para>InvestmentsAuthGetResponse defines the response schema for <c>/investments/auth/get</c></para>
/// </summary>
public record InvestmentsAuthGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The accounts for which data is being retrieved</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.Account> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>The holdings belonging to investment accounts associated with the Item. Details of the securities in the holdings are provided in the <c>securities</c> field.</para>
	/// </summary>
	[JsonPropertyName("holdings")]
	public IReadOnlyList<Entity.Holding> Holdings { get; init; } = default!;

	/// <summary>
	/// <para>Objects describing the securities held in the accounts associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("securities")]
	public IReadOnlyList<Entity.Security> Securities { get; init; } = default!;

	/// <summary>
	/// <para>Information about the account owners for the accounts associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("owners")]
	public IReadOnlyList<Entity.InvestmentsAuthOwner> Owners { get; init; } = default!;

	/// <summary>
	/// <para>Identifying information for transferring holdings to an investments account.</para>
	/// </summary>
	[JsonPropertyName("numbers")]
	public Entity.InvestmentsAuthGetNumbers Numbers { get; init; } = default!;

	/// <summary>
	/// <para>Object with metadata pertaining to the source of data for the account numbers, owners, and holdings that are returned.</para>
	/// </summary>
	[JsonPropertyName("data_sources")]
	public Entity.InvestmentsAuthDataSources DataSources { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

}

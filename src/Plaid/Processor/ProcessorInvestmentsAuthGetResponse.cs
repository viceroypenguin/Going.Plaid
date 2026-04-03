namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorInvestmentsAuthGetResponse defines the response schema for <c>/processor/investments/auth/get</c></para>
/// </summary>
public record ProcessorInvestmentsAuthGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A single account at a financial institution.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public Entity.Account Account { get; init; } = default!;

	/// <summary>
	/// <para>The holdings belonging to the investment account. Details of the securities in the holdings are provided in the <c>securities</c> field.</para>
	/// </summary>
	[JsonPropertyName("holdings")]
	public IReadOnlyList<Entity.Holding> Holdings { get; init; } = default!;

	/// <summary>
	/// <para>Objects describing the securities held in the account.</para>
	/// </summary>
	[JsonPropertyName("securities")]
	public IReadOnlyList<Entity.Security> Securities { get; init; } = default!;

	/// <summary>
	/// <para>Information about the account owners for the account.</para>
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
	/// <para>Additional information for accounts of 401k subtype.</para>
	/// </summary>
	[JsonPropertyName("account_details_401k")]
	public IReadOnlyList<Entity.InvestmentsAuthAccountDetails401k>? AccountDetails401k { get; init; } = default!;

	/// <summary>
	/// <para>When true, this field indicates that the Item's portfolio was manually created with the Investments Fallback flow.</para>
	/// </summary>
	[JsonPropertyName("is_investments_fallback_item")]
	public bool? IsInvestmentsFallbackItem { get; init; } = default!;

}

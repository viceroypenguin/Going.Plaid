namespace Going.Plaid.Investments;

/// <summary>
/// <para>InvestmentsHoldingsGetResponse defines the response schema for <c>/investments/holdings/get</c></para>
/// </summary>
public record InvestmentsHoldingsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The accounts associated with the Item</para>
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
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

	/// <summary>
	/// <para>When true, this field indicates that the Item's portfolio was manually created with the Investments Fallback flow.</para>
	/// </summary>
	[JsonPropertyName("is_investments_fallback_item")]
	public bool? IsInvestmentsFallbackItem { get; init; } = default!;
}
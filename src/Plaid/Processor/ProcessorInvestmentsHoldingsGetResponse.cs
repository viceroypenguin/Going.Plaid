namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorInvestmentsHoldingsGetResponse defines the response schema for <c>/processor/invesments/holdings/get</c></para>
/// </summary>
public record ProcessorInvestmentsHoldingsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A single account at a financial institution.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public Entity.Account Account { get; init; } = default!;

	/// <summary>
	/// <para>The holdings belonging to investment accounts associated with the Item. Details of the securities in the holdings are provided in the <c>securities</c> field.</para>
	/// </summary>
	[JsonPropertyName("holdings")]
	public IReadOnlyList<Entity.Holding> Holdings { get; init; } = default!;

	/// <summary>
	/// <para>Objects describing the securities held in the account.</para>
	/// </summary>
	[JsonPropertyName("securities")]
	public IReadOnlyList<Entity.Security> Securities { get; init; } = default!;

	/// <summary>
	/// <para>When true, this field indicates that the Item's portfolio was manually created with the Investments Fallback flow.</para>
	/// </summary>
	[JsonPropertyName("is_investments_fallback_item")]
	public bool? IsInvestmentsFallbackItem { get; init; } = default!;

}

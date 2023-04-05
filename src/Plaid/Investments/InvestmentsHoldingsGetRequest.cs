namespace Going.Plaid.Investments;

/// <summary>
/// <para>InvestmentsHoldingsGetRequest defines the request schema for <c>/investments/holdings/get</c></para>
/// </summary>
public partial class InvestmentsHoldingsGetRequest : RequestBase
{
	/// <summary>
	/// <para>An optional object to filter <c>/investments/holdings/get</c> results. If provided, must not be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.InvestmentHoldingsGetRequestOptions? Options { get; set; } = default!;
}
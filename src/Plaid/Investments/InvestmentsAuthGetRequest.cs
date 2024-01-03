namespace Going.Plaid.Investments;

/// <summary>
/// <para>InvestmentsAuthGetRequest defines the request schema for <c>/investments/auth/get</c></para>
/// </summary>
public partial class InvestmentsAuthGetRequest : RequestBase
{
	/// <summary>
	/// <para>An optional object to filter <c>/investments/auth/get</c> results.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.InvestmentsAuthGetRequestOptions? Options { get; set; } = default!;

}

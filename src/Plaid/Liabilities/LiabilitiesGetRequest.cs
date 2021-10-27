namespace Going.Plaid.Liabilities;

/// <summary>
/// <para>LiabilitiesGetRequest defines the request schema for <c>/liabilities/get</c></para>
/// </summary>
public partial class LiabilitiesGetRequest : RequestBase
{
	/// <summary>
	/// <para>An optional object to filter <c>/liabilities/get</c> results. If provided, <c>options</c> cannot be null.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.LiabilitiesGetRequestOptions Options { get; set; } = default!;
}
namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/originator/list</c></para>
/// </summary>
public partial class TransferOriginatorListRequest : RequestBase
{
	/// <summary>
	/// <para>The maximum number of transfers to return.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; } = default!;

	/// <summary>
	/// <para>The number of transfers to skip before returning results.</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int Offset { get; set; } = default!;
}
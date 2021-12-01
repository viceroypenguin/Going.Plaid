namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/sweep/get</c></para>
/// </summary>
public partial class TransferSweepGetRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a sweep.</para>
	/// </summary>
	[JsonPropertyName("sweep_id")]
	public string SweepId { get; set; } = default!;
}
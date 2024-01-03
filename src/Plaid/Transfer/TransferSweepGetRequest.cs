namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/sweep/get</c></para>
/// </summary>
public partial class TransferSweepGetRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid's unique identifier for the sweep (UUID) or a shortened form consisting of the first 8 characters of the identifier (8-digit hexadecimal string).</para>
	/// </summary>
	[JsonPropertyName("sweep_id")]
	public string SweepId { get; set; } = default!;

}

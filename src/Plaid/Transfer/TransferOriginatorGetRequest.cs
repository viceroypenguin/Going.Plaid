namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/originator/get</c></para>
/// </summary>
public partial class TransferOriginatorGetRequest : RequestBase
{
	/// <summary>
	/// <para>Client ID of the end customer (i.e. the originator).</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string OriginatorClientId { get; set; } = default!;
}
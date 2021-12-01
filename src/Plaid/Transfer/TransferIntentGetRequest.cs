namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/intent/get</c></para>
/// </summary>
public partial class TransferIntentGetRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid's unique identifier for a transfer intent object.</para>
	/// </summary>
	[JsonPropertyName("transfer_intent_id")]
	public string TransferIntentId { get; set; } = default!;
}
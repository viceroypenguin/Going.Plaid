namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/cancel</c></para>
/// </summary>
public partial class TransferCancelRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string TransferId { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid client ID of the transfer originator. Should only be present if <c>client_id</c> is a third-party sender (TPS).</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	[Obsolete]
	public string? OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>Specifies the reason for cancelling transfer. This is required for RfP transfers, and will be ignored for other networks.</para>
	/// </summary>
	[JsonPropertyName("reason_code")]
	public Entity.ReasonCode? ReasonCode { get; set; } = default!;

}

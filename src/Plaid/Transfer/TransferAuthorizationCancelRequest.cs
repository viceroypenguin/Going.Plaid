namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/authorization/cancel</c></para>
/// </summary>
public partial class TransferAuthorizationCancelRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer authorization.</para>
	/// </summary>
	[JsonPropertyName("authorization_id")]
	public string AuthorizationId { get; set; } = default!;

}

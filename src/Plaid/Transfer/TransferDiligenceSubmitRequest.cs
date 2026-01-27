namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/diligence/submit</c></para>
/// </summary>
public partial class TransferDiligenceSubmitRequest : RequestBase
{
	/// <summary>
	/// <para>Client ID of the originator whose diligence that you want to submit.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>The diligence information for the originator.</para>
	/// </summary>
	[JsonPropertyName("originator_diligence")]
	public Entity.TransferOriginatorDiligence OriginatorDiligence { get; set; } = default!;

}

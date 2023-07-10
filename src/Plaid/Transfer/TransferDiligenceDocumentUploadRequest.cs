namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/diligence/document/upload</c></para>
/// </summary>
public partial class TransferDiligenceDocumentUploadRequest : RequestBase
{
	/// <summary>
	/// <para>The Client ID of the originator whose document that you want to upload.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>A file to upload.</para>
	/// </summary>
	[JsonPropertyName("file")]
	public string File { get; set; } = default!;

	/// <summary>
	/// <para>Specifies the purpose of the uploaded file.</para>
	/// </summary>
	[JsonPropertyName("purpose")]
	public Entity.TransferDocumentPurpose Purpose { get; set; } = default!;
}
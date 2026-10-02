namespace Going.Plaid.Protect;

/// <summary>
/// <para>Defines the response schema for <c>/protect/cash_advance/feedback/upload</c></para>
/// </summary>
public record ProtectCashAdvanceFeedbackUploadResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique identifier for the upload. Retain it: it is the identifier Plaid Support uses to look up this upload.</para>
	/// </summary>
	[JsonPropertyName("upload_id")]
	public string UploadId { get; init; } = default!;

}

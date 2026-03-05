namespace Going.Plaid.Entity;

/// <summary>
/// <para>Inputs for link session Trust Index models.</para>
/// </summary>
public class ProtectLinkModelInputs
{
	/// <summary>
	/// <para>A unique identifier for the Link session, used to compute a Trust Index score and fraud attributes.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string LinkSessionId { get; set; } = default!;

	/// <summary>
	/// <para>Controls whether transaction extraction must be complete before scoring. If <c>false</c> (default), returns a score whether or not transaction extraction is complete, as long as the link session is finished; if data has been extracted it will still be included in the score computation. If <c>true</c>, returns HTTP 400 with <c>error_type</c> = <c>INVALID_REQUEST</c> and <c>error_code</c> = <c>FAILED_PRECONDITION</c> if extraction is still in progress; once data is ready a score will be returned normally.</para>
	/// </summary>
	[JsonPropertyName("require_extracted_data")]
	public bool? RequireExtractedData { get; set; } = default!;

}

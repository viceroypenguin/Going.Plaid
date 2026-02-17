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
	/// <para>Whether to wait for data to be extracted before computing and returning a score. If set to <c>true</c> and <c>/protect/compute</c> is called before data has been extracted, an error will be returned indicating that data has not yet been extracted. If set to <c>false</c>, a score will be computed and returned regardless of whether data has been extracted. If <c>false</c> and data has been extracted, extracted data will still be included in the score computation. Defaults to <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("require_extracted_data")]
	public bool? RequireExtractedData { get; set; } = default!;

}

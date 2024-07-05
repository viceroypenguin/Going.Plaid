namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identity object used to specify document upload</para>
/// </summary>
public class LinkTokenCreateIdentity
{
	/// <summary>
	/// <para>Used to specify whether the Link session is Identity Document Upload</para>
	/// </summary>
	[JsonPropertyName("is_document_upload")]
	public bool? IsDocumentUpload { get; set; } = default!;

	/// <summary>
	/// <para>An array of <c>account_ids</c></para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string>? AccountIds { get; set; } = default!;

	/// <summary>
	/// <para>An array of parsing configurations. Valid parsing configurations are <c>ocr</c> and <c>risk_signals</c>. If parsing configurations are omitted, defaults to <c>ocr</c></para>
	/// </summary>
	[JsonPropertyName("parsing_configs")]
	public IReadOnlyList<Entity.IncomeVerificationDocParsingConfig>? ParsingConfigs { get; set; } = default!;

}

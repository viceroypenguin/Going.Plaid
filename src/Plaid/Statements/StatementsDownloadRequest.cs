namespace Going.Plaid.Statements;

/// <summary>
/// <para>StatementsDownloadRequest defines the request schema for <c>/statements/download</c></para>
/// </summary>
public partial class StatementsDownloadRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid's unique identifier for the statements.</para>
	/// </summary>
	[JsonPropertyName("statement_id")]
	public string StatementId { get; set; } = default!;

}

namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditAuditCopyTokenUpdateRequest defines the request schema for <c>/credit/audit_copy_token/update</c></para>
/// </summary>
public partial class CreditAuditCopyTokenUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>audit_copy_token</c> you would like to update.</para>
	/// </summary>
	[JsonPropertyName("audit_copy_token")]
	public string AuditCopyToken { get; set; } = default!;

	/// <summary>
	/// <para>Array of tokens which the specified Audit Copy Token will be updated with. The types of token supported are asset report token and employment report token. There can be at most 1 of each type can be in the array.</para>
	/// </summary>
	[JsonPropertyName("report_tokens")]
	public IReadOnlyList<string> ReportTokens { get; set; } = default!;
}
namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditAuditCopyTokenCreateRequest defines the request schema for <c>/credit/audit_copy_token/create</c></para>
/// </summary>
public partial class CreditAuditCopyTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>List of report tokens; can include at most one VOA/standard Asset Report tokens and one VOE Asset Report Token.</para>
	/// </summary>
	[JsonPropertyName("report_tokens")]
	public IReadOnlyList<string> ReportTokens { get; set; } = default!;

}

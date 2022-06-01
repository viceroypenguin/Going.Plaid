namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditAuditCopyTokenCreateRequest defines the request schema for <c>/credit/audit_copy_token/get</c></para>
/// </summary>
public partial class CreditAuditCopyTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>List of report tokens; can include both Asset Report tokens and Income Report tokens.</para>
	/// </summary>
	[JsonPropertyName("tokens")]
	public IReadOnlyList<string> Tokens { get; set; } = default!;

	/// <summary>
	/// <para>The <c>auditor_id</c> of the third party with whom you would like to share the Asset Report and/or Income Report.</para>
	/// </summary>
	[JsonPropertyName("auditor_id")]
	public string AuditorId { get; set; } = default!;
}
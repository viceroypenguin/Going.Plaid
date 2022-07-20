namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditAuditCopyTokenRemoveRequest defines the request schema for <c>/credit/audit_copy_token/remove</c></para>
/// </summary>
public partial class CreditAuditCopyTokenRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>audit_copy_token</c> granting access to the Audit Copy you would like to revoke.</para>
	/// </summary>
	[JsonPropertyName("audit_copy_token")]
	public string AuditCopyToken { get; set; } = default!;
}
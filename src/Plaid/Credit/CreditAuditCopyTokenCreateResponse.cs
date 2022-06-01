namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditAuditCopyTokenCreateResponse defines the response schema for <c>/credit/audit_copy_token/get</c></para>
/// </summary>
public record CreditAuditCopyTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A token that can be shared with a third party auditor to allow them to obtain access to the Asset or Income Report. This token should be stored securely.</para>
	/// </summary>
	[JsonPropertyName("audit_copy_token")]
	public string AuditCopyToken { get; init; } = default!;
}
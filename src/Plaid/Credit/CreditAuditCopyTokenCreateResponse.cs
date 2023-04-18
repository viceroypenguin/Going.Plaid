namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditAuditCopyTokenCreateResponse defines the response schema for <c>/credit/audit_copy_token/get</c></para>
/// </summary>
public record CreditAuditCopyTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A token that can be shared with a third party auditor, which allows them to fetch the Asset Reports attached to the token. This token should be stored securely.</para>
	/// </summary>
	[JsonPropertyName("audit_copy_token")]
	public string AuditCopyToken { get; init; } = default!;
}
namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditAuditCopyTokenUpdateResponse defines the response schema for <c>/credit/audit_copy_token/update</c></para>
/// </summary>
public record CreditAuditCopyTokenUpdateResponse : ResponseBase
{
	/// <summary>
	/// <para><c>true</c> if the Audit Copy Token was successfully updated.</para>
	/// </summary>
	[JsonPropertyName("updated")]
	public bool Updated { get; init; } = default!;

}

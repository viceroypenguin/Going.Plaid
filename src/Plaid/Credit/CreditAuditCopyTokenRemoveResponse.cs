namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditAuditCopyTokenRemoveResponse defines the response schema for <c>/credit/audit_copy_token/remove</c></para>
/// </summary>
public record CreditAuditCopyTokenRemoveResponse : ResponseBase
{
	/// <summary>
	/// <para><c>true</c> if the Audit Copy was successfully removed.</para>
	/// </summary>
	[JsonPropertyName("removed")]
	public bool Removed { get; init; } = default!;

}

namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditFreddieMacReportsGetRequest defines the request schema for <c>credit/asset_report/freddie_mac/get</c></para>
/// </summary>
public partial class CreditFreddieMacReportsGetRequest : RequestBase
{
	/// <summary>
	/// <para>A token that can be shared with a third party auditor to allow them to obtain access to the Asset Report. This token should be stored securely.</para>
	/// </summary>
	[JsonPropertyName("audit_copy_token")]
	public string AuditCopyToken { get; set; } = default!;

}

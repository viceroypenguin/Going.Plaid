namespace Going.Plaid.Entity;

/// <summary>
/// <para>ReportToken is a representation of a token that has a <c>report_type</c> field that can be one of <c>assets</c> or <c>income</c> and a <c>token</c> field which is the associated token with the <c>report_type</c>. The <c>token</c> can be an Asset Report token or Income Report token.</para>
/// </summary>
public class ReportToken
{
	/// <summary>
	/// <para>The report type. It can be <c>assets</c> or <c>income</c>.</para>
	/// </summary>
	[JsonPropertyName("report_type")]
	public Entity.ReportType ReportType { get; set; } = default!;

	/// <summary>
	/// <para>The report token. It can be an asset report token or an income report token.</para>
	/// </summary>
	[JsonPropertyName("token")]
	public string Token { get; set; } = default!;
}
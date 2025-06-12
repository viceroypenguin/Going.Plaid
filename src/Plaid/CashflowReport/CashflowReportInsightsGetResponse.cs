namespace Going.Plaid.CashflowReport;

/// <summary>
/// <para>CashflowReportInsightsGetResponse defines the response schema for <c>/cashflow_report/insights/get</c></para>
/// </summary>
public record CashflowReportInsightsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

	/// <summary>
	/// <para>An array containing the <c>accounts</c> associated with the Item for which transactions are being returned. Each transaction can be mapped to its corresponding account via the <c>account_id</c> field.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.BusinessAccount> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>Insights on the account level. These are only returned for Credit and Depository type accounts.</para>
	/// </summary>
	[JsonPropertyName("account_insights")]
	public Entity.CashflowAccountInsights AccountInsights { get; init; } = default!;

	/// <summary>
	/// <para>Datetime of last cashflow report generation in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> )</para>
	/// </summary>
	[JsonPropertyName("last_generated_time")]
	public DateTimeOffset LastGeneratedTime { get; init; } = default!;

}

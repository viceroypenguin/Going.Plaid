namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemHandleFraudReportResponse defines the response schema for <c>/item/handle_fraud_report</c></para>
/// </summary>
public record ItemHandleFraudReportResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique identifier representing the submitted report.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

}

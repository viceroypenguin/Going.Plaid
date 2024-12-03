namespace Going.Plaid.Credit;

/// <summary>
/// <para>CheckReportPdfGetRequest defines the request schema for <c>/cra/check_report/pdf/get</c></para>
/// </summary>
public partial class CheckReportPdfGetRequest : RequestBase
{
	/// <summary>
	/// <para>Use this field to include other reports in the PDF.</para>
	/// <para>Possible values: <c>cra_income_insights</c></para>
	/// </summary>
	[JsonPropertyName("add_ons")]
	public IReadOnlyList<Entity.CheckReportPdfGetRequestAddOnsEnum> AddOns { get; set; } = default!;
}

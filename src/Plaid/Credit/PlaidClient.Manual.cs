namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/cra/check_report/pdf/get</c> retrieves the most recent Consumer Report in PDF format. By default, the most recent Base Report (if it exists) for the user will be returned. To request that the most recent Income Insights report be included in the PDF as well, use the <c>add-ons</c> field.</para>
	/// <para>The response to <c>/asset_report/pdf/get</c> is the PDF binary data. The <c>request_id</c>  is returned in the <c>Plaid-Request-ID</c> header.</para>
	/// <para><a href="https://plaid.com/documents/sample-asset-report.pdf">View a sample PDF Asset Report</a></para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/assets/#asset_reportpdfget" /></remarks>
	public Task<FileResponse> CreditCheckReportPdfGetAsync(Credit.CheckReportPdfGetRequest request) =>
		PostAsync("/cra/check_report/pdf/get", request)
			.ParseFileResponseAsync();
}

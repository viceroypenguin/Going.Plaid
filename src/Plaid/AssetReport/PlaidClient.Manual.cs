namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/asset_report/pdf/get</c> endpoint retrieves the Asset Report in PDF format. Before calling <c>/asset_report/pdf/get</c>, you must first create the Asset Report using <c>/asset_report/create</c> (or filter an Asset Report using <c>/asset_report/filter</c>) and then wait for the <a href="https://plaid.com/docs/api/products/assets/#product_ready"><c>PRODUCT_READY</c></a> webhook to fire, indicating that the Report is ready to be retrieved.</para>
	/// <para>The response to <c>/asset_report/pdf/get</c> is the PDF binary data. The <c>request_id</c>  is returned in the <c>Plaid-Request-ID</c> header.</para>
	/// <para><a href="https://plaid.com/documents/sample-asset-report.pdf">View a sample PDF Asset Report</a></para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/assets/#asset_reportpdfget" /></remarks>
	public Task<FileResponse> AssetReportPdfGetAsync(AssetReport.AssetReportPdfGetRequest request) =>
	PostAsync("/asset_report/pdf/get", request)
			.ParseFileResponseAsync();
}

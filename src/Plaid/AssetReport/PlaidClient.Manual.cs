namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// </summary>
	/// <remarks></remarks>
	public Task<FileResponse> AssetReportPdfGetAsync(AssetReport.AssetReportPdfGetRequest request) =>
		PostAsync("/asset_report/pdf/get", request)
			.ParseFileResponseAsync();
}
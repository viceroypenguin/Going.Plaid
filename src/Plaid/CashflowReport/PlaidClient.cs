namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/cashflow_report/refresh</c> is an endpoint that initiates an on-demand extraction to fetch the newest transactions for an item (given an <c>item_id</c>). The item must already have Cashflow Report added as a product in order to call <c>/cashflow_report/refresh</c>.</para>
	/// <para>After calling <c>/cashflow_report/refresh</c>, Plaid will fire a webhook <c>CASHFLOW_REPORT_READY</c> alerting clients that new transactions data can then be ingested via <c>/cashflow_report/get</c> or the webhook will contain an error code informing there was an error in refreshing transactions data.</para>
	/// <para>Note that the <c>/cashflow_report/refresh</c> endpoint is not supported for Capital One (<c>ins_128026</c>) non-depository accounts and will result in a <c>PRODUCTS_NOT_SUPPORTED</c> error if called on an Item that contains only non-depository accounts from that institution.</para>
	/// <para>As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but up to 30 seconds or more). If you encounter errors, you may find it necessary to adjust your timeout period for requests.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#cashflowReportRefresh" /></remarks>
	public Task<CashflowReport.CashflowReportRefreshResponse> CashflowReportRefreshAsync(CashflowReport.CashflowReportRefreshRequest request) =>
		PostAsync("/cashflow_report/refresh", request)
			.ParseResponseAsync<CashflowReport.CashflowReportRefreshResponse>();

	/// <summary>
	/// <para>The <c>/cashflow_report/get</c> endpoint retrieves transactions data associated with an item. Transactions data is standardized across financial institutions.</para>
	/// <para>Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift. Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in <c>/transactions/get</c>.  For more details, see <a href="https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions">Pending and posted transactions</a>.</para>
	/// <para>Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the <c>count</c> and <c>cursor</c> parameters in conjunction with the <c>has_more</c> response body field to fetch all available transactions.</para>
	/// <para>Note that data isn't likely to be immediately available to <c>/cashflow_report/get</c>. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with cashflow_report, or if it wasn't, upon the first call to /cashflow_report/refresh. To be alerted when transaction data is ready to be fetched, listen for the <c>CASHFLOW_REPORT_READY</c> webhook.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#cashflowReportGet" /></remarks>
	public Task<CashflowReport.CashflowReportGetResponse> CashflowReportGetAsync(CashflowReport.CashflowReportGetRequest request) =>
		PostAsync("/cashflow_report/get", request)
			.ParseResponseAsync<CashflowReport.CashflowReportGetResponse>();

	/// <summary>
	/// <para>The <c>/cashflow_report/transactions/get</c> endpoint retrieves transactions data associated with an item. Transactions data is standardized across financial institutions.</para>
	/// <para>Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift. Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in <c>/transactions/get</c>.  For more details, see <a href="https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions">Pending and posted transactions</a>.</para>
	/// <para>Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the <c>count</c> and <c>cursor</c> parameters in conjunction with the <c>has_more</c> response body field to fetch all available transactions.</para>
	/// <para>Note that data isn't likely to be immediately available to <c>/cashflow_report/transactions/get</c>. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with cashflow_report, or if it wasn't, upon the first call to /cashflow_report/refresh. To be alerted when transaction data is ready to be fetched, listen for the <c>CASHFLOW_REPORT_READY</c> webhook.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#cashflowReportTransactionsGet" /></remarks>
	public Task<CashflowReport.CashflowReportTransactionsGetResponse> CashflowReportTransactionsGetAsync(CashflowReport.CashflowReportTransactionsGetRequest request) =>
		PostAsync("/cashflow_report/transactions/get", request)
			.ParseResponseAsync<CashflowReport.CashflowReportTransactionsGetResponse>();

	/// <summary>
	/// <para>The <c>/cashflow_report/insights/get</c> endpoint retrieves insights data associated with an item. Insights are only calculated on credit and depository accounts.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#cashflowReportInsightsGet" /></remarks>
	public Task<CashflowReport.CashflowReportInsightsGetResponse> CashflowReportInsightsGetAsync(CashflowReport.CashflowReportInsightsGetRequest request) =>
		PostAsync("/cashflow_report/insights/get", request)
			.ParseResponseAsync<CashflowReport.CashflowReportInsightsGetResponse>();

}

namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/statements/list</c> endpoint retrieves a list of all statements associated with the provided item.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/statements#statementslist" /></remarks>
	public Task<Statements.StatementsListResponse> StatementsListAsync(Statements.StatementsListRequest request) =>
		PostAsync("/statements/list", request)
			.ParseResponseAsync<Statements.StatementsListResponse>();

	/// <summary>
	/// <para>The <c>/statements/download</c> endpoint retrieves a single statement PDF in binary format.  The response will contain a <c>Plaid-Content-Hash</c> header containing a SHA 256 checksum of the statement. This can be used to verify that the file being sent by Plaid is the same file that was downloaded to your system.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/statements#statementsdownload" /></remarks>
	public Task<Statements.StatementsDownloadResponse> StatementsDownloadAsync(Statements.StatementsDownloadRequest request) =>
		PostAsync("/statements/download", request)
			.ParseResponseAsync<Statements.StatementsDownloadResponse>();

	/// <summary>
	/// <para><c>/statements/refresh</c> initiates an on-demand extraction to fetch the statements for the provided dates.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/statements#statementsrefresh" /></remarks>
	public Task<Statements.StatementsRefreshResponse> StatementsRefreshAsync(Statements.StatementsRefreshRequest request) =>
		PostAsync("/statements/refresh", request)
			.ParseResponseAsync<Statements.StatementsRefreshResponse>();

}

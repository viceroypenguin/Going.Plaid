namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/statements/list</c> endpoint retrieves a list of all statements associated with the provided item.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Statements.StatementsListResponse> StatementsListAsync(Statements.StatementsListRequest request) =>
		PostAsync("/statements/list", request)
			.ParseResponseAsync<Statements.StatementsListResponse>();

	/// <summary>
	/// <para>The <c>/statements/download</c> endpoint retrieves a single statement.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Statements.StatementsDownloadResponse> StatementsDownloadAsync(Statements.StatementsDownloadRequest request) =>
		PostAsync("/statements/download", request)
			.ParseResponseAsync<Statements.StatementsDownloadResponse>();
}
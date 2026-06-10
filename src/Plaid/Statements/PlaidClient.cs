namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/statements/list</c> endpoint retrieves a list of all statements associated with an Item.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/statements#statementslist" /></remarks>
	public Task<Statements.StatementsListResponse> StatementsListAsync(Statements.StatementsListRequest request) =>
		PostAsync("/statements/list", request)
			.ParseResponseAsync<Statements.StatementsListResponse>();

	/// <summary>
	/// <para><c>/statements/refresh</c> initiates an on-demand extraction to fetch the statements for the provided dates.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/statements#statementsrefresh" /></remarks>
	public Task<Statements.StatementsRefreshResponse> StatementsRefreshAsync(Statements.StatementsRefreshRequest request) =>
		PostAsync("/statements/refresh", request)
			.ParseResponseAsync<Statements.StatementsRefreshResponse>();

}

namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Allows financial institutions to retrieve information about Plaid clients for the purpose of building control-tower experiences</para>
	/// </summary>
	public Task<Application.ApplicationGetResponse> ApplicationGetAsync(Application.ApplicationGetRequest request) =>
		PostAsync("/application/get", request)
			.ParseResponseAsync<Application.ApplicationGetResponse>();
}
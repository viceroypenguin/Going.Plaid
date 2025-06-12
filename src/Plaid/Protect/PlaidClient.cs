namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Use this endpoint to get basic information about a user as it relates to their fraud profile with Protect.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/protect/#protectuserinsightsget" /></remarks>
	public Task<Protect.ProtectUserInsightsGetResponse> ProtectUserInsightsGetAsync(Protect.ProtectUserInsightsGetRequest request) =>
		PostAsync("/protect/user/insights/get", request)
			.ParseResponseAsync<Protect.ProtectUserInsightsGetResponse>();

	/// <summary>
	/// <para>Send a new event to enrich user data and optionally get a Trust Index score for the event.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/protect/#protecteventsend" /></remarks>
	public Task<Protect.ProtectEventSendResponse> ProtectEventSendAsync(Protect.ProtectEventSendRequest request) =>
		PostAsync("/protect/event/send", request)
			.ParseResponseAsync<Protect.ProtectEventSendResponse>();

	/// <summary>
	/// <para>Get information about a user event including Trust Index score and fraud attributes.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/protect/#protecteventget" /></remarks>
	public Task<Protect.ProtectEventGetResponse> ProtectEventGetAsync(Protect.ProtectEventGetRequest request) =>
		PostAsync("/protect/event/get", request)
			.ParseResponseAsync<Protect.ProtectEventGetResponse>();

}

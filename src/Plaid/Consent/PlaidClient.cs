namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>List a historical log of item consent events</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/consent/#consenteventsget" /></remarks>
	public Task<Consent.ConsentEventsGetResponse> ConsentEventsGetAsync(Consent.ConsentEventsGetRequest request) =>
		PostAsync("/consent/events/get", request)
			.ParseResponseAsync<Consent.ConsentEventsGetResponse>();

}

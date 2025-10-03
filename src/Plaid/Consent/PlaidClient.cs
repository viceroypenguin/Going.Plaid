namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>List a historical log of Item consent events. Consent logs are only available for events occurring on or after November 7, 2024. Extremely recent events (occurring within the past 12 hours) may not be available via this endpoint. Up to three years of consent logs will be available via the endpoint.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/consent/#consenteventsget" /></remarks>
	public Task<Consent.ConsentEventsGetResponse> ConsentEventsGetAsync(Consent.ConsentEventsGetRequest request) =>
		PostAsync("/consent/events/get", request)
			.ParseResponseAsync<Consent.ConsentEventsGetResponse>();

}

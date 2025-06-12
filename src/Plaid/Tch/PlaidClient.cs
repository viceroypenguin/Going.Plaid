namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>This endpoint allows us to receive token notifications from The Clearing House (TCH). The schema is defined by TCH.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docsnone" /></remarks>
	public Task<Tch.TCHNotificationResponse> TchNotificationsAsync(Tch.TCHNotification request) =>
		PostAsync("/tch/notifications", request)
			.ParseResponseAsync<Tch.TCHNotificationResponse>();

}

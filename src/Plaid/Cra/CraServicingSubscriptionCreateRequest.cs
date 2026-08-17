namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraServicingSubscriptionCreateRequest defines the request schema for <c>/cra/servicing/subscription/create</c>.</para>
/// </summary>
public partial class CraServicingSubscriptionCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

	/// <summary>
	/// <para>Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope Scope { get; set; } = default!;

	/// <summary>
	/// <para>The cadence at which products are generated and webhooks are fired. If the Qualify product is requested, cadence must be null or omitted, because Qualify's generation cadence is controlled by Plaid.</para>
	/// </summary>
	[JsonPropertyName("cadence")]
	public Entity.CraSubscriptionCadence? Cadence { get; set; } = default!;

	/// <summary>
	/// <para>The URL to which the webhook should be sent. If provided, this will override the URL set in the dashboard.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

	/// <summary>
	/// <para>The products included in this subscription.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.CraSubscriptionProductConfig> Products { get; set; } = default!;

}

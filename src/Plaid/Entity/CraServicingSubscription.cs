namespace Going.Plaid.Entity;

/// <summary>
/// <para>A single CRA servicing subscription.</para>
/// </summary>
public record CraServicingSubscription
{
	/// <summary>
	/// <para>A CRA servicing subscription identifier, in the format <c>cra-sub-&lt;environment&gt;-&lt;uuid&gt;</c>.</para>
	/// </summary>
	[JsonPropertyName("subscription_id")]
	public string SubscriptionId { get; init; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope Scope { get; init; } = default!;

	/// <summary>
	/// <para>The cadence at which products are generated and webhooks are fired. If the Qualify product is requested, cadence must be null or omitted, because Qualify's generation cadence is controlled by Plaid.</para>
	/// </summary>
	[JsonPropertyName("cadence")]
	public Entity.CraSubscriptionCadence? Cadence { get; init; } = default!;

	/// <summary>
	/// <para>The webhook URL Plaid sends report-update notifications to for this subscription, or null if none is set.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; init; } = default!;

	/// <summary>
	/// <para>The products this subscription covers, each with the options it is configured with.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.CraSubscriptionProductConfig> Products { get; init; } = default!;

}

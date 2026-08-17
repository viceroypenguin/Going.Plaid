namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxUserFireWebhookRequest defines the request schema for <c>/sandbox/user/fire_webhook</c></para>
/// </summary>
public partial class SandboxUserFireWebhookRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>The user token associated with the user for which data is being requested. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The webhook types that can be fired by this test endpoint.</para>
	/// </summary>
	[JsonPropertyName("webhook_type")]
	public Entity.SandboxUserFireWebhookType WebhookType { get; set; } = default!;

	/// <summary>
	/// <para>The webhook codes that can be fired by this test endpoint.</para>
	/// </summary>
	[JsonPropertyName("webhook_code")]
	public Entity.SandboxUserFireWebhookCode WebhookCode { get; set; } = default!;

	/// <summary>
	/// <para>The destination URL that the test webhook will be sent to.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

}

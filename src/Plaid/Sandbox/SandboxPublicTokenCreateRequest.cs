namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxPublicTokenCreateRequest defines the request schema for <c>/sandbox/public_token/create</c></para>
/// </summary>
public partial class SandboxPublicTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the institution the Item will be associated with</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; set; } = default!;

	/// <summary>
	/// <para>The products to initially pull for the Item. May be any products that the specified <c>institution_id</c> supports. This array may not be empty.</para>
	/// </summary>
	[JsonPropertyName("initial_products")]
	public IReadOnlyList<Entity.Products> InitialProducts { get; set; } = default!;

	/// <summary>
	/// <para>An optional set of options to be used when configuring the Item. If specified, must not be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.SandboxPublicTokenCreateRequestOptions? Options { get; set; } = default!;

	/// <summary>
	/// <para>The user token associated with the User data is being requested for. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

}

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
	/// <para>The products to initially pull for the Item. May be any products that the specified <c>institution_id</c>  supports. This array may not be empty.</para>
	/// </summary>
	[JsonPropertyName("initial_products")]
	public IReadOnlyList<Entity.Products> InitialProducts { get; set; } = default!;

	/// <summary>
	/// <para>An optional set of options to be used when configuring the Item. If specified, must not be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.SandboxPublicTokenCreateRequestOptions? Options { get; set; } = default!;

	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;
}
namespace Going.Plaid.User;

/// <summary>
/// <para>UserProductsTerminateRequest defines the request schema for <c>/user/products/terminate</c></para>
/// </summary>
public partial class UserProductsTerminateRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

	/// <summary>
	/// <para>The reason for terminating user-based products.</para>
	/// </summary>
	[JsonPropertyName("reason_code")]
	public Entity.ProductsTerminateReasonCode ReasonCode { get; set; } = default!;

	/// <summary>
	/// <para>Additional context or details about the reason for terminating user-based products. Personally identifiable information, such as an email address or phone number, should not be included in the <c>reason_note</c>.</para>
	/// </summary>
	[JsonPropertyName("reason_note")]
	public string? ReasonNote { get; set; } = default!;

}

namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraReportGetResponse defines the response schema for <c>/cra/report/get</c>.</para>
/// </summary>
public record CraReportGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The CRA report returned by <c>/cra/report/get</c>.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.CraReportGetReport Report { get; init; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>The unique ID representing the end user that you supplied as <c>client_user_id</c> when creating the user via <c>/user/create</c>. <c>null</c> if the user has no <c>client_user_id</c> on record.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; init; } = default!;

	/// <summary>
	/// <para>User or report-level errors that affected the overall report but do not map to a specific product failure.</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.CraReportWarning> Warnings { get; init; } = default!;

}

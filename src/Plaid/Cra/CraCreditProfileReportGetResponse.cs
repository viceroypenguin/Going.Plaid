namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCreditProfileReportGetResponse defines the response schema for <c>/cra/credit_profile/report/get</c>.</para>
/// </summary>
public record CraCreditProfileReportGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Contains data for the CRA Credit Profile Report.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.CraCreditProfileReport Report { get; init; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

	/// <summary>
	/// <para>If the report generation was successful but a subset of data could not be retrieved, this array will contain information about the errors causing information to be missing</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.CraReportWarning> Warnings { get; init; } = default!;

}

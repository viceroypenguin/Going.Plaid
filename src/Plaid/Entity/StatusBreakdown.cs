namespace Going.Plaid.Entity;

/// <summary>
/// <para>A detailed breakdown of the institution's performance for a request type. The values for <c>success</c>, <c>error_plaid</c>, and <c>error_institution</c> sum to 1.</para>
/// </summary>
public record StatusBreakdown
{
	/// <summary>
	/// <para>The percentage of login attempts that are successful, expressed as a decimal.</para>
	/// </summary>
	[JsonPropertyName("success")]
	public decimal Success { get; init; } = default!;

	/// <summary>
	/// <para>The percentage of logins that are failing due to an internal Plaid issue, expressed as a decimal.</para>
	/// </summary>
	[JsonPropertyName("error_plaid")]
	public decimal ErrorPlaid { get; init; } = default!;

	/// <summary>
	/// <para>The percentage of logins that are failing due to an issue in the institution's system, expressed as a decimal.</para>
	/// </summary>
	[JsonPropertyName("error_institution")]
	public decimal ErrorInstitution { get; init; } = default!;

	/// <summary>
	/// <para>The <c>refresh_interval</c> may be <c>DELAYED</c> or <c>STOPPED</c> even when the success rate is high. This value is only returned for Transactions status breakdowns.</para>
	/// </summary>
	[JsonPropertyName("refresh_interval")]
	public Entity.StatusBreakdownRefreshIntervalEnum RefreshInterval { get; init; } = default!;
}
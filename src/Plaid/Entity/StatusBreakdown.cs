namespace Going.Plaid.Entity;

/// <summary>
/// <para>A detailed breakdown of the institution's performance for a request type. The values for <c>success</c>, <c>error_plaid</c>, and <c>error_institution</c> sum to 1. The time range used for calculating the breakdown may range from the most recent few minutes to the past six hours. In general, smaller institutions will show status that was calculated over a longer period of time. For Investment updates, which are refreshed less frequently, the period assessed may be 24 hours or more. For more details, see <a href="https://plaid.com/docs/account/activity/#institution-status-details">Institution status details</a>.</para>
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
	public Entity.StatusBreakdownRefreshIntervalEnum? RefreshInterval { get; init; } = default!;
}
namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Auth product. This field can be used to enable or disable extended Auth flows for the resulting Link session. Omitting any field will result in a default that can be configured by your account manager.</para>
/// </summary>
public class LinkTokenCreateRequestAuth
{
	/// <summary>
	/// <para>Specifies whether Auth Type Select is enabled for the Link session, allowing the end user to choose between linking instantly or manually prior to selecting their financial institution. Note that this can only be true if <c>same_day_microdeposits_enabled</c> is set to true.</para>
	/// </summary>
	[JsonPropertyName("auth_type_select_enabled")]
	public bool? AuthTypeSelectEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Automated Micro-deposits flow.</para>
	/// </summary>
	[JsonPropertyName("automated_microdeposits_enabled")]
	public bool? AutomatedMicrodepositsEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Instant Match flow. As of November 2022, Instant Match will be enabled by default. Instant Match can be disabled by setting this field to <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("instant_match_enabled")]
	public bool? InstantMatchEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Same Day Micro-deposits flow.</para>
	/// </summary>
	[JsonPropertyName("same_day_microdeposits_enabled")]
	public bool? SameDayMicrodepositsEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Instant Micro-deposits flow.</para>
	/// </summary>
	[JsonPropertyName("instant_microdeposits_enabled")]
	public bool? InstantMicrodepositsEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies what type of [Reroute to Credentials](https://plaid.com/docs/auth/coverage/same-day/#reroute-to-credentials) pane should be used in the Link session for the Same Day Micro-deposits flow. As of October 15 2023, the default setting is <c>OPTIONAL</c>.</para>
	/// </summary>
	[JsonPropertyName("reroute_to_credentials")]
	public Entity.LinkTokenCreateRequestAuthRerouteToCredentialsEnum? RerouteToCredentials { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Database Match flow.</para>
	/// </summary>
	[JsonPropertyName("database_match_enabled")]
	public bool? DatabaseMatchEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Database Insights flow.</para>
	/// </summary>
	[JsonPropertyName("database_insights_enabled")]
	public bool? DatabaseInsightsEnabled { get; set; } = default!;

	/// <summary>
	/// <para>This field has been deprecated in favor of <c>auth_type_select_enabled</c>.</para>
	/// </summary>
	[JsonPropertyName("flow_type")]
	public Entity.LinkTokenCreateRequestAuthFlowTypeEnum? FlowType { get; set; } = default!;

}

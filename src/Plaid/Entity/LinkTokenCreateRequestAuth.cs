namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Auth product. This field can be used to enable or disable extended Auth flows for the resulting Link session. Omitting any field will result in a default that can be configured by your account manager. The default behavior described in the documentation is the default behavior that will apply if you have not requested your account manager to apply a different default.</para>
/// </summary>
public class LinkTokenCreateRequestAuth
{
	/// <summary>
	/// <para>Specifies whether Auth Type Select is enabled for the Link session, allowing the end user to choose between linking via a credentials-based flow (i.e. Instant Auth, Instant Match, Automated Micro-deposits) or a manual flow that does not require login (all other Auth flows) prior to selecting their financial institution. Default behavior is <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("auth_type_select_enabled")]
	public bool? AuthTypeSelectEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Automated Micro-deposits flow. Default behavior is <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("automated_microdeposits_enabled")]
	public bool? AutomatedMicrodepositsEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Instant Match flow. Instant Match is enabled by default. Instant Match can be disabled by setting this field to <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("instant_match_enabled")]
	public bool? InstantMatchEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Same Day Micro-deposits flow.  Default behavior is <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("same_day_microdeposits_enabled")]
	public bool? SameDayMicrodepositsEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Instant Micro-deposits flow.  Default behavior for Plaid teams created after November 2023 is <c>false</c>; default behavior for Plaid teams created before that date is <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("instant_microdeposits_enabled")]
	public bool? InstantMicrodepositsEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies what type of [Reroute to Credentials](https://plaid.com/docs/auth/coverage/same-day/#reroute-to-credentials) pane should be used in the Link session for the Same Day Micro-deposits flow. Default behavior is <c>OPTIONAL</c>.</para>
	/// </summary>
	[JsonPropertyName("reroute_to_credentials")]
	public Entity.LinkTokenCreateRequestAuthRerouteToCredentialsEnum? RerouteToCredentials { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Database Match flow. Default behavior is <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("database_match_enabled")]
	public bool? DatabaseMatchEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Database Insights flow. Database Insights is currently in closed beta; for access, contact your Account Manager. Default behavior is <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("database_insights_enabled")]
	public bool? DatabaseInsightsEnabled { get; set; } = default!;

	/// <summary>
	/// <para>This field has been deprecated in favor of <c>auth_type_select_enabled</c>.</para>
	/// </summary>
	[JsonPropertyName("flow_type")]
	public Entity.LinkTokenCreateRequestAuthFlowTypeEnum? FlowType { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for SMS micro-deposits verification. Default behavior is <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("sms_microdeposits_verification_enabled")]
	public bool? SmsMicrodepositsVerificationEnabled { get; set; } = default!;

}

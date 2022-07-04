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
	public bool AuthTypeSelectEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Automated Micro-deposits flow.</para>
	/// </summary>
	[JsonPropertyName("automated_microdeposits_enabled")]
	public bool AutomatedMicrodepositsEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Instant Match flow.</para>
	/// </summary>
	[JsonPropertyName("instant_match_enabled")]
	public bool InstantMatchEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Specifies whether the Link session is enabled for the Same Day Micro-deposits flow.</para>
	/// </summary>
	[JsonPropertyName("same_day_microdeposits_enabled")]
	public bool SameDayMicrodepositsEnabled { get; set; } = default!;

	/// <summary>
	/// <para>This field has been deprecated in favor of <c>auth_type_select_enabled</c>.</para>
	/// </summary>
	[JsonPropertyName("flow_type")]
	public Entity.LinkTokenCreateRequestAuthFlowTypeEnum? FlowType { get; set; } = default!;
}

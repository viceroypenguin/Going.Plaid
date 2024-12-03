namespace Going.Plaid.DepositSwitch;

/// <summary>
/// <para>(Deprecated) DepositSwitchAltCreateRequest defines the request schema for <c>/deposit_switch/alt/create</c></para>
/// </summary>
public partial class DepositSwitchAltCreateRequest : RequestBase
{
	/// <summary>
	/// <para>(Deprecated) The deposit switch destination account</para>
	/// </summary>
	[JsonPropertyName("target_account")]
	[Obsolete]
	public Entity.DepositSwitchTargetAccount TargetAccount { get; set; } = default!;

	/// <summary>
	/// <para>(Deprecated) The deposit switch target user</para>
	/// </summary>
	[JsonPropertyName("target_user")]
	[Obsolete]
	public Entity.DepositSwitchTargetUser TargetUser { get; set; } = default!;

	/// <summary>
	/// <para>(Deprecated) Options to configure the <c>/deposit_switch/create</c> request. If provided, cannot be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	[Obsolete]
	public Entity.DepositSwitchCreateRequestOptions? Options { get; set; } = default!;

	/// <summary>
	/// <para>ISO-3166-1 alpha-2 country code standard.</para>
	/// </summary>
	[JsonPropertyName("country_code")]
	public Entity.CountryCode? CountryCode { get; set; } = default!;

}

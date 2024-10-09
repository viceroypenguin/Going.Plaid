namespace Going.Plaid.DepositSwitch;

/// <summary>
/// <para>(Deprecated) DepositSwitchCreateRequest defines the request schema for <c>/deposit_switch/create</c></para>
/// </summary>
public partial class DepositSwitchCreateRequest : RequestBase
{
	/// <summary>
	/// <para>Access token for the target Item, typically provided in the Import Item response.</para>
	/// </summary>
	[JsonPropertyName("target_access_token")]
	public string TargetAccessToken { get; set; } = default!;

	/// <summary>
	/// <para>Plaid Account ID that specifies the target bank account. This account will become the recipient for a user's direct deposit.</para>
	/// </summary>
	[JsonPropertyName("target_account_id")]
	public string TargetAccountId { get; set; } = default!;

	/// <summary>
	/// <para>ISO-3166-1 alpha-2 country code standard.</para>
	/// </summary>
	[JsonPropertyName("country_code")]
	public Entity.CountryCode? CountryCode { get; set; } = default!;

	/// <summary>
	/// <para>(Deprecated) Options to configure the <c>/deposit_switch/create</c> request. If provided, cannot be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.DepositSwitchCreateRequestOptions? Options { get; set; } = default!;

}

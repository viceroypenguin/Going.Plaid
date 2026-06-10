namespace Going.Plaid.Protect;

/// <summary>
/// <para>Request object for /protect/compute</para>
/// </summary>
public partial class ProtectComputeRequest : RequestBase
{
	/// <summary>
	/// <para>The name of the Trust Index model to use for scoring, with a major.minor version suffix. Examples: <c>ti-link-session-2.0</c> (link-session fraud), <c>ti-identity-2.0</c> (identity fraud), <c>cash-advance-onboarding-1.0</c> (first cash advance), and <c>cash-advance-ongoing-1.0</c> (subsequent cash advances). The model specified may require certain fields within <c>model_inputs</c>; for example, <c>ti-link-session-2.0</c> requires the <c>link</c> field. Cash-advance models do not use <c>model_inputs</c>.</para>
	/// </summary>
	[JsonPropertyName("model")]
	public string Model { get; set; } = default!;

	/// <summary>
	/// <para>Represents an end user for <c>/protect/compute</c> requests.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.ProtectUser User { get; set; } = default!;

	/// <summary>
	/// <para>Inputs required by certain Trust Index models. The <c>link</c> field is required for link-session models. Other model families (including cash-advance) are identified by <c>user</c> alone and do not use this object.</para>
	/// </summary>
	[JsonPropertyName("model_inputs")]
	public Entity.ProtectModelInputs? ModelInputs { get; set; } = default!;

}

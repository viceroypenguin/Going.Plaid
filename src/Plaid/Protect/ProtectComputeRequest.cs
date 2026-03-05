namespace Going.Plaid.Protect;

/// <summary>
/// <para>Request object for /protect/compute</para>
/// </summary>
public partial class ProtectComputeRequest : RequestBase
{
	/// <summary>
	/// <para>The name of the Trust Index model to use for calculating the Trust Index Score, with a major.minor version suffix. Examples include <c>ti-link-session-2.0</c> and <c>ti-identity-2.0</c>. The model specified may require certain fields within <c>model_inputs</c>. For example, <c>ti-link-session-2.0</c> requires the <c>link</c> field to be provided in <c>model_inputs</c>.</para>
	/// </summary>
	[JsonPropertyName("model")]
	public string Model { get; set; } = default!;

	/// <summary>
	/// <para>Represents an end user for /protect/compute requests.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.ProtectUser User { get; set; } = default!;

	/// <summary>
	/// <para>Inputs for the Trust Index model. The <c>link</c> field is required for any link session model type.</para>
	/// </summary>
	[JsonPropertyName("model_inputs")]
	public Entity.ProtectModelInputs? ModelInputs { get; set; } = default!;

}

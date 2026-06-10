namespace Going.Plaid.Entity;

/// <summary>
/// <para>Inputs required by certain Trust Index models. The <c>link</c> field is required for link-session models. Other model families (including cash-advance) are identified by <c>user</c> alone and do not use this object.</para>
/// </summary>
public class ProtectModelInputs
{
	/// <summary>
	/// <para>Inputs for link session Trust Index models.</para>
	/// </summary>
	[JsonPropertyName("link")]
	public Entity.ProtectLinkModelInputs? Link { get; set; } = default!;

	/// <summary>
	/// <para>Inputs for Protect SDK Trust Index models.</para>
	/// </summary>
	[JsonPropertyName("sdk")]
	public Entity.ProtectSDKModelInputs? Sdk { get; set; } = default!;

}

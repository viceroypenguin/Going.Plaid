namespace Going.Plaid.Entity;

/// <summary>
/// <para>Inputs for the Trust Index model. The <c>link</c> field is required for any link session model type.</para>
/// </summary>
public class ProtectModelInputs
{
	/// <summary>
	/// <para>Inputs for link session Trust Index models.</para>
	/// </summary>
	[JsonPropertyName("link")]
	public Entity.ProtectLinkModelInputs? Link { get; set; } = default!;

}

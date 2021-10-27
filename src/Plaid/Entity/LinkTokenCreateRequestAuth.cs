namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Auth product. This field is currently only required if using the Flexible Auth product (currently in closed beta).</para>
/// </summary>
public class LinkTokenCreateRequestAuth
{
	/// <summary>
	/// <para>The optional Auth flow to use. Currently only used to enable Flexible Auth.</para>
	/// </summary>
	[JsonPropertyName("flow_type")]
	public Entity.LinkTokenCreateRequestAuthFlowTypeEnum FlowType { get; set; } = default!;
}
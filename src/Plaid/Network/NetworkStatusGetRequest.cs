namespace Going.Plaid.Network;

/// <summary>
/// <para>NetworkStatusGetRequest defines the request schema for <c>/network/status/get</c></para>
/// </summary>
public partial class NetworkStatusGetRequest : RequestBase
{
	/// <summary>
	/// <para>An object specifying information about the end user for the network status check.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.NetworkStatusGetUser User { get; set; } = default!;

	/// <summary>
	/// <para>The id of a template defined in Plaid Dashboard. This field is used if you have additional criteria that you want to check against (e.g. Layer eligibility).</para>
	/// </summary>
	[JsonPropertyName("template_id")]
	public string? TemplateId { get; set; } = default!;

}

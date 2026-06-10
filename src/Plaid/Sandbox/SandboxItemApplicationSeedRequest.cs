namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxItemApplicationSeedRequest defines the request schema for <c>/sandbox/item/application/seed</c></para>
/// </summary>
public partial class SandboxItemApplicationSeedRequest : RequestBase
{
	/// <summary>
	/// <para>This field will map to the application ID that is returned from <c>/item/application/list</c>, or provided to the institution in an oauth redirect.</para>
	/// </summary>
	[JsonPropertyName("application_id")]
	public string ApplicationId { get; set; } = default!;

}

namespace Going.Plaid.Identity;

/// <summary>
/// <para>IdentityGetRequest defines the request schema for <c>/identity/get</c></para>
/// </summary>
public partial class IdentityGetRequest : RequestBase
{
	/// <summary>
	/// <para>An optional object to filter <c>/identity/get</c> results.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.IdentityGetRequestOptions? Options { get; set; } = default!;

}

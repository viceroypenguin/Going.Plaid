namespace Going.Plaid.Auth;

/// <summary>
/// <para>AuthGetRequest defines the request schema for <c>/auth/get</c></para>
/// </summary>
public partial class AuthGetRequest : RequestBase
{
	/// <summary>
	/// <para>An optional object to filter <c>/auth/get</c> results.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.AuthGetRequestOptions? Options { get; set; } = default!;
}
namespace Going.Plaid.Link;

/// <summary>
/// <para>LinkTokenGetRequest defines the request schema for <c>/link/token/get</c></para>
/// </summary>
public class LinkTokenGetRequest : RequestBase
{
	/// <summary>
	/// <para>A <c>link_token</c> from a previous invocation of <c>/link/token/create</c></para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; set; } = default!;
}
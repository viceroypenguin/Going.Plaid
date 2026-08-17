namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaIssuesV1MatchRequest defines the request schema for <c>/beta/issues/v1/match</c>.</para>
/// </summary>
public partial class BetaIssuesV1MatchRequest : RequestBase
{
	/// <summary>
	/// <para>The type of identifier supplied to <c>/beta/issues/v1/match</c>.</para>
	/// </summary>
	[JsonPropertyName("identifier_type")]
	public Entity.BetaIssuesV1MatchIdentifierType IdentifierType { get; set; } = default!;

	/// <summary>
	/// <para>The Item, request, Link session, or Account identifier to match.</para>
	/// </summary>
	[JsonPropertyName("identifier")]
	public string Identifier { get; set; } = default!;

}

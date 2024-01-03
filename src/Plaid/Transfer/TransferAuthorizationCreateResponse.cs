namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/authorization/create</c></para>
/// </summary>
public record TransferAuthorizationCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Contains the authorization decision for a proposed transfer.</para>
	/// </summary>
	[JsonPropertyName("authorization")]
	public Entity.TransferAuthorization Authorization { get; init; } = default!;

}

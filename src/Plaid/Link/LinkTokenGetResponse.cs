namespace Going.Plaid.Link;

/// <summary>
/// <para>LinkTokenGetResponse defines the response schema for <c>/link/token/get</c></para>
/// </summary>
public record LinkTokenGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A <c>link_token</c>, which can be supplied to Link in order to initialize it and receive a <c>public_token</c>, which can be exchanged for an <c>access_token</c>.</para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; init; } = default!;

	/// <summary>
	/// <para>The creation timestamp for the <c>link_token</c>, in ISO 8601 format.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset? CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>The expiration timestamp for the <c>link_token</c>, in ISO 8601 format.</para>
	/// </summary>
	[JsonPropertyName("expiration")]
	public DateTimeOffset? Expiration { get; init; } = default!;

	/// <summary>
	/// <para>An object specifying the arguments originally provided to the <c>/link/token/create</c> call.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.LinkTokenGetMetadataResponse Metadata { get; init; } = default!;
}
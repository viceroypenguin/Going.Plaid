namespace Going.Plaid.LinkDelivery;

/// <summary>
/// <para>LinkDeliveryGetRequest defines the response schema for <c>/link_delivery/get</c></para>
/// </summary>
public record LinkDeliveryGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The status of the given Link Delivery Session.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.LinkDeliverySessionStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the time the given Link Delivery Session was created at</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>The public tokens returned by the Link session upon completion</para>
	/// </summary>
	[JsonPropertyName("public_tokens")]
	public IReadOnlyList<string> PublicTokens { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the time the given Link Delivery Session was completed at</para>
	/// </summary>
	[JsonPropertyName("completed_at")]
	public DateTimeOffset? CompletedAt { get; init; } = default!;
}
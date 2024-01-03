namespace Going.Plaid.Entity;

/// <summary>
/// <para>Displayed if a user exits Link without successfully linking an Item.</para>
/// </summary>
public record LinkSessionExitMetadata
{
	/// <summary>
	/// <para>An institution object. If the Item was created via Same-Day micro-deposit verification, will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("institution")]
	public Entity.LinkSessionExitMetadataInstitution? Institution { get; init; } = default!;

	/// <summary>
	/// <para>The point at which the user exited the Link flow. One of the following values.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public string? Status { get; init; } = default!;

	/// <summary>
	/// <para>A unique identifier associated with a user's actions and events through the Link flow. Include this identifier when opening a support ticket for faster turnaround.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string? LinkSessionId { get; init; } = default!;

	/// <summary>
	/// <para>The request ID for the last request made by Link. This can be shared with Plaid Support to expedite investigation.</para>
	/// </summary>
	[JsonPropertyName("request_id")]
	public string? RequestId { get; init; } = default!;

}

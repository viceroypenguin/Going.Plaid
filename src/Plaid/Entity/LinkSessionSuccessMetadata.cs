namespace Going.Plaid.Entity;

/// <summary>
/// <para>Displayed once a user has successfully linked their Item.</para>
/// </summary>
public record LinkSessionSuccessMetadata
{
	/// <summary>
	/// <para>An institution object. If the Item was created via Same-Day micro-deposit verification, will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("institution")]
	public Entity.LinkSessionSuccessMetadataInstitution? Institution { get; init; } = default!;

	/// <summary>
	/// <para>A list of accounts attached to the connected Item. If Account Select is enabled via the developer dashboard, <c>accounts</c> will only include selected accounts.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.LinkSessionSuccessMetadataAccount>? Accounts { get; init; } = default!;

	/// <summary>
	/// <para>A unique identifier associated with a user's actions and events through the Link flow. Include this identifier when opening a support ticket for faster turnaround.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string? LinkSessionId { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("transfer_status")]
	public Entity.LinkSessionSuccessMetadataTransferStatus? TransferStatus { get; init; } = default!;

}

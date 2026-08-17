namespace Going.Plaid.Item;

/// <summary>
/// <para>Describes the connected application for a particular end user.</para>
/// </summary>
public record ItemApplicationListResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of connected applications.</para>
	/// </summary>
	[JsonPropertyName("applications")]
	public IReadOnlyList<Entity.ConnectedApplication> Applications { get; init; } = default!;

	/// <summary>
	/// <para>A list of applications that the user previously connected and has since disconnected. Disconnected applications carry no <c>scopes</c> or <c>created_at</c>, since the user has revoked their access.</para>
	/// </summary>
	[JsonPropertyName("disconnected_applications")]
	public IReadOnlyList<Entity.DisconnectedApplication>? DisconnectedApplications { get; init; } = default!;

}

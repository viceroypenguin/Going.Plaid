namespace Going.Plaid.Entity;

/// <summary>
/// <para>A Beacon User Revision identifies a Beacon User at some point in its revision history.</para>
/// </summary>
public record BeaconUserRevision
{
	/// <summary>
	/// <para>ID of the associated Beacon User.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>The <c>version</c> field begins with 1 and increments with each subsequent revision.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public int Version { get; init; } = default!;

}

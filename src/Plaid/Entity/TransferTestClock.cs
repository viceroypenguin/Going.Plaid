namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines the test clock for a transfer.</para>
/// </summary>
public record TransferTestClock
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string TestClockId { get; init; } = default!;

	/// <summary>
	/// <para>The virtual timestamp on the test clock. This will be of the form <c>2006-01-02T15:04:05Z</c>.</para>
	/// </summary>
	[JsonPropertyName("virtual_time")]
	public DateTimeOffset VirtualTime { get; init; } = default!;
}
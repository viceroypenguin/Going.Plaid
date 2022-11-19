namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/test_clock/create</c></para>
/// </summary>
public partial class SandboxTransferTestClockCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The frozen timestamp on the test clock. This will be of the form <c>2006-01-02T15:04:05Z</c>.</para>
	/// </summary>
	[JsonPropertyName("frozen_timestamp")]
	public DateTimeOffset FrozenTimestamp { get; set; } = default!;
}
namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/sweep/simulate</c></para>
/// </summary>
public partial class SandboxTransferSweepSimulateRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock. If provided, the sweep to be simulated is created on the day of the <c>virtual_time</c> on the <c>test_clock</c>. If the date of <c>virtual_time</c> is on weekend or a federal holiday, the next available banking day is used.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string? TestClockId { get; set; } = default!;
}
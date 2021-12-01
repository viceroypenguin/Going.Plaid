namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/sweep/simulate</c></para>
/// </summary>
public partial class SandboxTransferSweepSimulateRequest : RequestBase
{
	/// <summary>
	/// <para>A set of <c>pending</c> or <c>posted</c> transfers which should be included in the sweep.</para>
	/// </summary>
	[JsonPropertyName("swept")]
	public IReadOnlyList<string> Swept { get; set; } = default!;

	/// <summary>
	/// <para>A set of transfers to be <c>reverse_swept</c>. Transfers must first be <c>reversed</c> using the <c>/sandbox/transfer/simulate</c> endpoint before they can be <c>reverse_swept</c></para>
	/// </summary>
	[JsonPropertyName("reverse_swept")]
	public IReadOnlyList<string> ReverseSwept { get; set; } = default!;
}
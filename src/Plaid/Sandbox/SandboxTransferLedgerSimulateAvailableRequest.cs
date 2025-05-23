namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/ledger/simulate_available</c></para>
/// </summary>
public partial class SandboxTransferLedgerSimulateAvailableRequest : RequestBase
{
	/// <summary>
	/// <para>Specify which ledger balance to simulate converting pending balance to available balance. If this field is left blank, this will default to id of the default ledger balance.</para>
	/// </summary>
	[JsonPropertyName("ledger_id")]
	public string? LedgerId { get; set; } = default!;

	/// <summary>
	/// <para>Client ID of the end customer (i.e. the originator). Only applicable to Platform Payments customers.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock. If provided, only the pending balance that is due before the <c>virtual_timestamp</c> on the test clock will be converted.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string? TestClockId { get; set; } = default!;

	/// <summary>
	/// <para>The webhook URL to which a <c>TRANSFER_EVENTS_UPDATE</c> webhook should be sent.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

}

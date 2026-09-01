namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxCraServicingSimulateRequest defines the request schema for <c>/sandbox/cra/servicing/simulate</c></para>
/// </summary>
public partial class SandboxCraServicingSimulateRequest : RequestBase
{
	/// <summary>
	/// <para>The Servicing subscription to simulate an update for. Upon calling this endpoint, Plaid will simulate a report creation for all products referenced by this subscription ID.</para>
	/// </summary>
	[JsonPropertyName("subscription_id")]
	public string SubscriptionId { get; set; } = default!;

	/// <summary>
	/// <para>The user to simulate an update for, in place of a <c>subscription_id</c>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>Optional parameters controlling the simulated report.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.SandboxCraServicingSimulateRequestOptions? Options { get; set; } = default!;

}

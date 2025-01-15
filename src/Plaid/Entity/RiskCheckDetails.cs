namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional information for the <c>risk_check</c> step.</para>
/// </summary>
public record RiskCheckDetails
{
	/// <summary>
	/// <para>The status of a step in the Identity Verification process.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.IdentityVerificationStepStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Result summary object specifying values for <c>behavior</c> attributes of risk check, when available.</para>
	/// </summary>
	[JsonPropertyName("behavior")]
	public Entity.RiskCheckBehavior? Behavior { get; init; } = default!;

	/// <summary>
	/// <para>Result summary object specifying values for <c>email</c> attributes of risk check.</para>
	/// </summary>
	[JsonPropertyName("email")]
	public Entity.RiskCheckEmail? Email { get; init; } = default!;

	/// <summary>
	/// <para>Result summary object specifying values for <c>phone</c> attributes of risk check.</para>
	/// </summary>
	[JsonPropertyName("phone")]
	public Entity.RiskCheckPhone? Phone { get; init; } = default!;

	/// <summary>
	/// <para>Array of result summary objects specifying values for <c>device</c> attributes of risk check.</para>
	/// </summary>
	[JsonPropertyName("devices")]
	public IReadOnlyList<Entity.RiskCheckDevice> Devices { get; init; } = default!;

	/// <summary>
	/// <para>Result summary object capturing abuse signals related to <c>identity abuse</c>, e.g. stolen and synthetic identity fraud. These attributes are only available for US identities and some signals may not be available depending on what information was collected.</para>
	/// </summary>
	[JsonPropertyName("identity_abuse_signals")]
	public Entity.RiskCheckIdentityAbuseSignals? IdentityAbuseSignals { get; init; } = default!;

	/// <summary>
	/// <para>Result summary object specifying values for network attributes of risk check.</para>
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.RiskCheckNetwork? Network { get; init; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional information for the <c>risk_check</c> step.</para>
/// </summary>
public record RiskCheckDetails
{
	/// <summary>
	/// <para>The status of a step in the identity verification process.</para>
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
}
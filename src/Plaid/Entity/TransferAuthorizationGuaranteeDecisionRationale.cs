namespace Going.Plaid.Entity;

/// <summary>
/// <para>The rationale for Plaid's decision to not guarantee a transfer. Will be <c>null</c> unless <c>guarantee_decision</c> is <c>NOT_GUARANTEED</c>.</para>
/// </summary>
public record TransferAuthorizationGuaranteeDecisionRationale
{
	/// <summary>
	/// <para>A code representing the reason Plaid declined to guarantee this transfer:</para>
	/// </summary>
	[JsonPropertyName("code")]
	public Entity.TransferAuthorizationGuaranteeDecisionRationaleCode Code { get; init; } = default!;

	/// <summary>
	/// <para>A human-readable description of why the transfer cannot be guaranteed.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;
}
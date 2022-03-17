namespace Going.Plaid.Entity;

/// <summary>
/// <para>The rationale for Plaid's decision regarding a proposed transfer. It is always set for <c>declined</c> decisions, and may or may not be null for <c>approved</c> decisions.</para>
/// </summary>
public record TransferAuthorizationDecisionRationale
{
	/// <summary>
	/// <para>A code representing the rationale for approving or declining the proposed transfer. Possible values are:</para>
	/// </summary>
	[JsonPropertyName("code")]
	public Entity.TransferAuthorizationDecisionRationaleCode Code { get; init; } = default!;

	/// <summary>
	/// <para>A human-readable description of the code associated with a transfer approval or transfer decline.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;
}
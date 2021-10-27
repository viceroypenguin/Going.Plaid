namespace Going.Plaid.Entity;

/// <summary>
/// <para>The rationale for Plaid's decision regarding a proposed transfer. Will be null for <c>approved</c> decisions.</para>
/// </summary>
public record TransferAuthorizationDecisionRationale
{
	/// <summary>
	/// <para>A code representing the rationale for permitting or declining the proposed transfer. Possible values are:</para>
	/// </summary>
	[JsonPropertyName("code")]
	public Entity.TransferAuthorizationDecisionRationaleCodeEnum Code { get; init; } = default!;

	/// <summary>
	/// <para>A human-readable description of the code associated with a permitted transfer or transfer decline.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;
}
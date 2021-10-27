namespace Going.Plaid.Entity;

/// <summary>
/// <para>TransferAuthorization contains the authorization decision for a proposed transfer</para>
/// </summary>
public record TransferAuthorization
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer authorization.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>The datetime representing when the authorization was created, in the format "2006-01-02T15:04:05Z".</para>
	/// </summary>
	[JsonPropertyName("created")]
	public string Created { get; init; } = default!;

	/// <summary>
	/// <para>A decision regarding the proposed transfer.</para>
	/// </summary>
	[JsonPropertyName("decision")]
	public Entity.TransferAuthorizationDecisionEnum Decision { get; init; } = default!;

	/// <summary>
	/// <para>The rationale for Plaid's decision regarding a proposed transfer. Will be null for <c>approved</c> decisions.</para>
	/// </summary>
	[JsonPropertyName("decision_rationale")]
	public Entity.TransferAuthorizationDecisionRationale? DecisionRationale { get; init; } = default!;

	/// <summary>
	/// <para>Details regarding the proposed transfer.</para>
	/// </summary>
	[JsonPropertyName("proposed_transfer")]
	public Entity.TransferAuthorizationProposedTransfer ProposedTransfer { get; init; } = default!;
}
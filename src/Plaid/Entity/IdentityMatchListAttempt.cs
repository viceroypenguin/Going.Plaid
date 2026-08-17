namespace Going.Plaid.Entity;

/// <summary>
/// <para>A Link-originated Identity Match attempt.</para>
/// </summary>
public record IdentityMatchListAttempt
{
	/// <summary>
	/// <para>Identifier for the Identity Match attempt.</para>
	/// </summary>
	[JsonPropertyName("attempt_id")]
	public string AttemptId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>Time at which the attempt was created.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>Link session that produced the attempt.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string LinkSessionId { get; init; } = default!;

	/// <summary>
	/// <para>Link customization that supplied the ruleset.</para>
	/// </summary>
	[JsonPropertyName("link_customization_name")]
	public string LinkCustomizationName { get; init; } = default!;

	/// <summary>
	/// <para>Revision of the Identity Match ruleset that was applied.</para>
	/// </summary>
	[JsonPropertyName("ruleset_revision")]
	public int RulesetRevision { get; init; } = default!;

	/// <summary>
	/// <para>Link outcome for the Identity Match attempt.</para>
	/// </summary>
	[JsonPropertyName("outcome")]
	public Entity.IdentityMatchListOutcome Outcome { get; init; } = default!;

	/// <summary>
	/// <para>Account ID associated with a <c>PASS</c> outcome. Null for <c>FAIL</c> or <c>UNKNOWN</c> outcomes.</para>
	/// </summary>
	[JsonPropertyName("outcome_account_id")]
	public string? OutcomeAccountId { get; init; } = default!;

	/// <summary>
	/// <para>Per-account match scores. Empty if the attempt data is unavailable.</para>
	/// </summary>
	[JsonPropertyName("scores")]
	public IReadOnlyList<Entity.IdentityMatchListAttemptScore> Scores { get; init; } = default!;

}

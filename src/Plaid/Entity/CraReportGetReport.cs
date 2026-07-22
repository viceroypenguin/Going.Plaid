namespace Going.Plaid.Entity;

/// <summary>
/// <para>The CRA report returned by <c>/cra/report/get</c>.</para>
/// </summary>
public record CraReportGetReport
{
	/// <summary>
	/// <para>The date and time the report was retrieved.</para>
	/// </summary>
	[JsonPropertyName("retrieved_time")]
	public DateTimeOffset RetrievedTime { get; init; } = default!;

	/// <summary>
	/// <para>Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope Scope { get; init; } = default!;

	/// <summary>
	/// <para>The stage in the lending lifecycle for which the report is being retrieved.</para>
	/// </summary>
	[JsonPropertyName("decision_stage")]
	public Entity.CraReportDecisionStage DecisionStage { get; init; } = default!;

	/// <summary>
	/// <para>Describes the reason you are generating a Consumer Report for this user. When calling <c>/link/token/create</c>, this field is required when using Plaid Check (CRA) products; invalid if not using Plaid Check (CRA) products.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.ConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; init; } = default!;

	/// <summary>
	/// <para>Per-product report data. Each entry corresponds to one requested product.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.CraReportGetResponseProduct> Products { get; init; } = default!;

}

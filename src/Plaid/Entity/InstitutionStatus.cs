namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of an institution is determined by the health of its Item logins, Transactions updates, Investments updates, Liabilities updates, Auth requests, Balance requests, Identity requests, Investments requests, and Liabilities requests. A login attempt is conducted during the initial Item add in Link. If there is not enough traffic to accurately calculate an institution's status, Plaid will return null rather than potentially inaccurate data.</para>
/// <para>Institution status is accessible in the Dashboard and via the API using the <c>/institutions/get_by_id</c> endpoint with the <c>options.include_status</c> option set to true. Note that institution status is not available in the Sandbox environment.</para>
/// </summary>
public record InstitutionStatus
{
	/// <summary>
	/// <para>A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.</para>
	/// </summary>
	[JsonPropertyName("item_logins")]
	public Entity.ProductStatus? ItemLogins { get; init; } = default!;

	/// <summary>
	/// <para>A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.</para>
	/// </summary>
	[JsonPropertyName("transactions_updates")]
	public Entity.ProductStatus? TransactionsUpdates { get; init; } = default!;

	/// <summary>
	/// <para>A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.</para>
	/// </summary>
	[JsonPropertyName("auth")]
	public Entity.ProductStatus? Auth { get; init; } = default!;

	/// <summary>
	/// <para>A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.</para>
	/// </summary>
	[JsonPropertyName("identity")]
	public Entity.ProductStatus? Identity { get; init; } = default!;

	/// <summary>
	/// <para>A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.</para>
	/// </summary>
	[JsonPropertyName("investments_updates")]
	public Entity.ProductStatus? InvestmentsUpdates { get; init; } = default!;

	/// <summary>
	/// <para>A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.</para>
	/// </summary>
	[JsonPropertyName("liabilities_updates")]
	public Entity.ProductStatus? LiabilitiesUpdates { get; init; } = default!;

	/// <summary>
	/// <para>A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.</para>
	/// </summary>
	[JsonPropertyName("liabilities")]
	public Entity.ProductStatus? Liabilities { get; init; } = default!;

	/// <summary>
	/// <para>A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.</para>
	/// </summary>
	[JsonPropertyName("investments")]
	public Entity.ProductStatus? Investments { get; init; } = default!;

	/// <summary>
	/// <para>Details of recent health incidents associated with the institution.</para>
	/// </summary>
	[JsonPropertyName("health_incidents")]
	public IReadOnlyList<Entity.HealthIncident>? HealthIncidents { get; init; } = default!;

}

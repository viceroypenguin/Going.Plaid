namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes the last time each datatype was accessed by an application.</para>
/// </summary>
public record LastDataAccessTimes
{
	/// <summary>
	/// <para>ID of the application accessing data.</para>
	/// </summary>
	[JsonPropertyName("application_id")]
	public string ApplicationId { get; init; } = default!;

	/// <summary>
	/// <para>The last time account_balance_info was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("account_balance_info")]
	public DateTimeOffset? AccountBalanceInfo { get; init; } = default!;

	/// <summary>
	/// <para>The last time account_routing_number was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("account_routing_number")]
	public DateTimeOffset? AccountRoutingNumber { get; init; } = default!;

	/// <summary>
	/// <para>The last time contact_details was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("contact_details")]
	public DateTimeOffset? ContactDetails { get; init; } = default!;

	/// <summary>
	/// <para>The last time transactions was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public DateTimeOffset? Transactions { get; init; } = default!;

	/// <summary>
	/// <para>The last time credit_and_loans was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("credit_and_loans")]
	public DateTimeOffset? CreditAndLoans { get; init; } = default!;

	/// <summary>
	/// <para>The last time investments was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("investments")]
	public DateTimeOffset? Investments { get; init; } = default!;

	/// <summary>
	/// <para>The last time payroll_info was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("payroll_info")]
	public DateTimeOffset? PayrollInfo { get; init; } = default!;

	/// <summary>
	/// <para>The last time transaction_risk_info was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("transaction_risk_info")]
	public DateTimeOffset? TransactionRiskInfo { get; init; } = default!;

}

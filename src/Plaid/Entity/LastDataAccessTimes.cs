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
	/// <para>The last time <c>account_balance_info</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("account_balance_info")]
	public DateTimeOffset? AccountBalanceInfo { get; init; } = default!;

	/// <summary>
	/// <para>The last time <c>account_routing_number</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("account_routing_number")]
	public DateTimeOffset? AccountRoutingNumber { get; init; } = default!;

	/// <summary>
	/// <para>The last time <c>contact_details</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("contact_details")]
	public DateTimeOffset? ContactDetails { get; init; } = default!;

	/// <summary>
	/// <para>The last time <c>transactions</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public DateTimeOffset? Transactions { get; init; } = default!;

	/// <summary>
	/// <para>The last time <c>credit_and_loans</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("credit_and_loans")]
	public DateTimeOffset? CreditAndLoans { get; init; } = default!;

	/// <summary>
	/// <para>The last time <c>investments</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("investments")]
	public DateTimeOffset? Investments { get; init; } = default!;

	/// <summary>
	/// <para>The last time <c>payroll_info</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("payroll_info")]
	public DateTimeOffset? PayrollInfo { get; init; } = default!;

	/// <summary>
	/// <para>The last time <c>transaction_risk_info</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("transaction_risk_info")]
	public DateTimeOffset? TransactionRiskInfo { get; init; } = default!;

}

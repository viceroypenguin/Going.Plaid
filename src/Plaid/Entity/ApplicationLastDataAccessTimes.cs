namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes the last time each datatype was accessed by an application.</para>
/// </summary>
public record ApplicationLastDataAccessTimes
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
	/// <para>The last time <c>contact_info</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("contact_info")]
	public DateTimeOffset? ContactInfo { get; init; } = default!;

	/// <summary>
	/// <para>The last time <c>transactions</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public DateTimeOffset? Transactions { get; init; } = default!;

	/// <summary>
	/// <para>The last time <c>credit_loan_info</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("credit_loan_info")]
	public DateTimeOffset? CreditLoanInfo { get; init; } = default!;

	/// <summary>
	/// <para>The last time <c>investments</c> was accessed by this application in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format in UTC. null if never accessed.</para>
	/// </summary>
	[JsonPropertyName("investments")]
	public DateTimeOffset? Investments { get; init; } = default!;

}

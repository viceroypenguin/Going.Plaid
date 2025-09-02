namespace Going.Plaid.Entity;

/// <summary>
/// <para>The product access being requested. Used to or disallow product access across all accounts. If unset, defaults to all products allowed.</para>
/// </summary>
public record ProductAccess
{
	/// <summary>
	/// <para>Allow access to statements. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("statements")]
	public bool? Statements { get; init; } = default!;

	/// <summary>
	/// <para>Allow access to the Identity product (name, email, phone, address). Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("identity")]
	public bool? Identity { get; init; } = default!;

	/// <summary>
	/// <para>Allow access to account number details. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("auth")]
	public bool? Auth { get; init; } = default!;

	/// <summary>
	/// <para>Allow access to transaction details. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public bool? Transactions { get; init; } = default!;

	/// <summary>
	/// <para>Allow access to <c>accounts_details_transactions</c>. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("accounts_details_transactions")]
	public bool? AccountsDetailsTransactions { get; init; } = default!;

	/// <summary>
	/// <para>Allow access to <c>accounts_routing_number</c>. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("accounts_routing_number")]
	public bool? AccountsRoutingNumber { get; init; } = default!;

	/// <summary>
	/// <para>Allow access to <c>accounts_statements</c>. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("accounts_statements")]
	public bool? AccountsStatements { get; init; } = default!;

	/// <summary>
	/// <para>Allow access to <c>accounts_tax_statements</c>. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("accounts_tax_statements")]
	public bool? AccountsTaxStatements { get; init; } = default!;

	/// <summary>
	/// <para>Allow access to <c>customers_profiles</c>. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("customers_profiles")]
	public bool? CustomersProfiles { get; init; } = default!;

}

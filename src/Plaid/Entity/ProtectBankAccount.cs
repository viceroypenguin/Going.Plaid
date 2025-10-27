namespace Going.Plaid.Entity;

/// <summary>
/// <para>Bank account information associated with the incident.</para>
/// </summary>
public class ProtectBankAccount
{
	/// <summary>
	/// <para>Plaid's unique identifier for the account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; set; } = default!;

	/// <summary>
	/// <para>Full account number of the bank account.</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string? AccountNumber { get; set; } = default!;

	/// <summary>
	/// <para>Routing number of the bank account. Must be present if <c>account_number</c> is present.</para>
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string? RoutingNumber { get; set; } = default!;

}

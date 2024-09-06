namespace Going.Plaid.Entity;

/// <summary>
/// <para>Depository account information for the associated user.</para>
/// </summary>
public class BeaconUserRequestDepositoryAccount
{
	/// <summary>
	/// <para>Must be a valid US Bank Account Number</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string AccountNumber { get; set; } = default!;

	/// <summary>
	/// <para>The routing number of the account.</para>
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string RoutingNumber { get; set; } = default!;

}

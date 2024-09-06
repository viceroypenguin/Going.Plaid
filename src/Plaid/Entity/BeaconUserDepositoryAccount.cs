namespace Going.Plaid.Entity;

/// <summary>
/// <para>Depository account information for the associated user.</para>
/// </summary>
public record BeaconUserDepositoryAccount
{
	/// <summary>
	/// <para>The last 2-4 numeric characters of this account’s account number.</para>
	/// </summary>
	[JsonPropertyName("account_mask")]
	public string AccountMask { get; init; } = default!;

	/// <summary>
	/// <para>The routing number of the account.</para>
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string RoutingNumber { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("added_at")]
	public DateTimeOffset AddedAt { get; init; } = default!;

}

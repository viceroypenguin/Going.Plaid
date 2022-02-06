namespace Going.Plaid.Entity;

/// <summary>
/// <para>The deposit switch destination account</para>
/// </summary>
public class DepositSwitchTargetAccount
{
	/// <summary>
	/// <para>Account number for deposit switch destination</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string AccountNumber { get; set; } = default!;

	/// <summary>
	/// <para>Routing number for deposit switch destination</para>
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string RoutingNumber { get; set; } = default!;

	/// <summary>
	/// <para>The name of the deposit switch destination account, as it will be displayed to the end user in the Deposit Switch interface. It is not required to match the name used in online banking.</para>
	/// </summary>
	[JsonPropertyName("account_name")]
	public string AccountName { get; set; } = default!;

	/// <summary>
	/// <para>The account subtype of the account, either <c>checking</c> or <c>savings</c>.</para>
	/// </summary>
	[JsonPropertyName("account_subtype")]
	public Entity.DepositSwitchTargetAccountAccountSubtypeEnum AccountSubtype { get; set; } = default!;
}
namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>BankTransferMigrateAccountRequest defines the request schema for <c>/bank_transfer/migrate_account</c></para>
/// </summary>
public class BankTransferMigrateAccountRequest : RequestBase
{
	/// <summary>
	/// <para>The user's account number.</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string AccountNumber { get; set; } = default!;

	/// <summary>
	/// <para>The user's routing number.</para>
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string RoutingNumber { get; set; } = default!;

	/// <summary>
	/// <para>The type of the bank account (<c>checking</c> or <c>savings</c>).</para>
	/// </summary>
	[JsonPropertyName("account_type")]
	public string AccountType { get; set; } = default!;
}
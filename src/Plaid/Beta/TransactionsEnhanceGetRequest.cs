namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsEnhanceGetRequest defines the request schema for <c>/transactions/enhance</c>.</para>
/// </summary>
public partial class TransactionsEnhanceGetRequest : RequestBase
{
	/// <summary>
	/// <para>The type of account for the requested transactions (<c>depository</c> or <c>credit</c>).</para>
	/// </summary>
	[JsonPropertyName("account_type")]
	public string AccountType { get; set; } = default!;

	/// <summary>
	/// <para>An array of raw transactions to be enhanced.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.ClientProvidedRawTransaction> Transactions { get; set; } = default!;

}

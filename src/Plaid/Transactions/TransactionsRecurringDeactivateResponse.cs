namespace Going.Plaid.Transactions;

/// <summary>
/// <para>TransactionsRecurringDeactivateResponse defines the response schema for <c>/transactions/recurring/deactivate</c></para>
/// </summary>
public record TransactionsRecurringDeactivateResponse : ResponseBase
{
	/// <summary>
	/// <para>Message indicating that the deactivation of the product was successful.</para>
	/// </summary>
	[JsonPropertyName("message")]
	public string Message { get; init; } = default!;
}
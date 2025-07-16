namespace Going.Plaid.Entity;

/// <summary>
/// <para>Account numbers associated with the counterparty, when available.</para>
/// <para>This field is currently only filled in for select financial institutions in Europe.</para>
/// </summary>
public record CounterpartyNumbers
{
	/// <summary>
	/// <para>Identifying information for a UK bank account via BACS.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.CounterpartyNumbersBACS? Bacs { get; init; } = default!;

	/// <summary>
	/// <para>Account numbers using the International Bank Account Number and BIC/SWIFT code format.</para>
	/// </summary>
	[JsonPropertyName("international")]
	public Entity.CounterpartyNumbersInternational? International { get; init; } = default!;

}

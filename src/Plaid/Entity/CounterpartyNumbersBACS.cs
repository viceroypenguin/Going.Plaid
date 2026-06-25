namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identifying information for a UK bank account via Bacs.</para>
/// </summary>
public record CounterpartyNumbersBACS
{
	/// <summary>
	/// <para>The Bacs account number for the account.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public string? Account { get; init; } = default!;

	/// <summary>
	/// <para>The Bacs sort code for the account.</para>
	/// </summary>
	[JsonPropertyName("sort_code")]
	public string? SortCode { get; init; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identifying information for a UK bank account via BACS.</para>
/// </summary>
public record CounterpartyNumbersBACS
{
	/// <summary>
	/// <para>The BACS account number for the account.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public string? Account { get; init; } = default!;

	/// <summary>
	/// <para>The BACS sort code for the account.</para>
	/// </summary>
	[JsonPropertyName("sort_code")]
	public string? SortCode { get; init; } = default!;

}

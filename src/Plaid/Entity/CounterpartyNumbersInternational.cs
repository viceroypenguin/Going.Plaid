namespace Going.Plaid.Entity;

/// <summary>
/// <para>Account numbers using the International Bank Account Number and BIC/SWIFT code format.</para>
/// </summary>
public record CounterpartyNumbersInternational
{
	/// <summary>
	/// <para>International Bank Account Number (IBAN).</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; init; } = default!;

	/// <summary>
	/// <para>Bank identifier code (BIC) for this counterparty.</para>
	/// </summary>
	[JsonPropertyName("bic")]
	public string? Bic { get; init; } = default!;

}

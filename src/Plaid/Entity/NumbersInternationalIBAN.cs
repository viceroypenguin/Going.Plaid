namespace Going.Plaid.Entity;

/// <summary>
/// <para>Account numbers using the International Bank Account Number and BIC/SWIFT code format.</para>
/// </summary>
public record NumbersInternationalIBAN
{
	/// <summary>
	/// <para>International Bank Account Number (IBAN).</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string Iban { get; init; } = default!;

	/// <summary>
	/// <para>The Business Identifier Code, also known as SWIFT code, for this bank account.</para>
	/// </summary>
	[JsonPropertyName("bic")]
	public string Bic { get; init; } = default!;
}
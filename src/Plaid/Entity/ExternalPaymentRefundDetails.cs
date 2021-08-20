namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public record ExternalPaymentRefundDetails
{
	/// <summary>
	/// <para>The name of the account holder.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The International Bank Account Number (IBAN) for the account.</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.RecipientBACS? Bacs { get; init; } = default!;
}
namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of a bank income verification in link</para>
/// </summary>
public record CreditSessionBankIncomeResult
{
	/// <summary>
	/// <para>The terminal status of the bank income verification.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.CreditSessionBankIncomeStatus Status { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; init; } = default!;
}
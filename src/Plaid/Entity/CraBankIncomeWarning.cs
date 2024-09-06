namespace Going.Plaid.Entity;

/// <summary>
/// <para>The warning associated with the data that was unavailable.</para>
/// </summary>
public record CraBankIncomeWarning
{
	/// <summary>
	/// <para>The warning type which will always be <c>BANK_INCOME_WARNING</c>.</para>
	/// </summary>
	[JsonPropertyName("warning_type")]
	public Entity.CreditBankIncomeWarningType? WarningType { get; init; } = default!;

	/// <summary>
	/// <para>The warning code identifies a specific kind of warning.</para>
	/// </summary>
	[JsonPropertyName("warning_code")]
	public Entity.CraBankIncomeWarningCode? WarningCode { get; init; } = default!;

	/// <summary>
	/// <para>An error object and associated <c>item_id</c> used to identify a specific Item and error when a batch operation operating on multiple Items has encountered an error in one of the Items.</para>
	/// </summary>
	[JsonPropertyName("cause")]
	public Entity.CraBankIncomeCause? Cause { get; init; } = default!;

}

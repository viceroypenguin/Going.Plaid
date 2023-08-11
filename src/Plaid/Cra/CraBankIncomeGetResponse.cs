namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraBankIncomeGetResponse defines the response schema for <c>/cra/bank_income/get</c>.</para>
/// </summary>
public record CraBankIncomeGetResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("bank_income")]
	public IReadOnlyList<Entity.CraBankIncome>? BankIncome { get; init; } = default!;
}
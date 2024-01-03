namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditBankIncomeGetResponse defines the response schema for <c>/credit/bank_income/get</c></para>
/// </summary>
public record CreditBankIncomeGetResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("bank_income")]
	public IReadOnlyList<Entity.CreditBankIncome>? BankIncome { get; init; } = default!;

}

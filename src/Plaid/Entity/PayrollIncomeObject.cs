namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing payroll data.</para>
/// </summary>
public record PayrollIncomeObject
{
	/// <summary>
	/// <para>ID of the payroll provider account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Array of pay stubs for the user.</para>
	/// </summary>
	[JsonPropertyName("pay_stubs")]
	public IReadOnlyList<Entity.PayStub> PayStubs { get; init; } = default!;

	/// <summary>
	/// <para>Array of tax form W-2s.</para>
	/// </summary>
	[JsonPropertyName("w2s")]
	public IReadOnlyList<Entity.CreditW2> W2s { get; init; } = default!;
}
namespace Going.Plaid.Entity;

/// <summary>
/// <para>This object includes a code and description to describe medium risk transactions and above on /accounts/balance/get.</para>
/// </summary>
public record RiskReason
{
	/// <summary>
	/// <para>A code that represents the type of risk associated with the proposed transaction.</para>
	/// <para>The codes are from PL01 to PL08 and from BK01 to BK07. For a full listing of risk reason codes, see <a href="https://plaid.com/docs/balance/balance-plus/#risk-codes">Risk codes</a>.</para>
	/// </summary>
	[JsonPropertyName("code")]
	public string Code { get; init; } = default!;

	/// <summary>
	/// <para>A human-readable description explaining the risk code associated with the proposed transaction and some recommended actions. This field is subject to change; any programmatic logic should be based on the <c>code</c> field instead.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

}

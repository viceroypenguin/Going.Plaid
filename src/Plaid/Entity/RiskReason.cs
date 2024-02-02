namespace Going.Plaid.Entity;

/// <summary>
/// <para>This object includes a code and description to describe medium risk transactions and above on /accounts/balance/get.</para>
/// </summary>
public record RiskReason
{
	/// <summary>
	/// <para>A code that represents the type of risk associated with the proposed transaction.</para>
	/// <para>The codes are from PL01 to PL07 and from BK01 to BK07.</para>
	/// </summary>
	[JsonPropertyName("code")]
	public string? Code { get; init; } = default!;

	/// <summary>
	/// <para>A brief description explaining the risk associated with the proposed transaction and some recommended actions.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; init; } = default!;

}

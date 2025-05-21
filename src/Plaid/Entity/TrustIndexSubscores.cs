namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains sub-score metadata. Temporary stub with no properties yet.</para>
/// </summary>
public record TrustIndexSubscores
{
	/// <summary>
	/// <para>Represents Trust Index Subscore.</para>
	/// </summary>
	[JsonPropertyName("device_and_connection")]
	public Entity.TrustIndexSubscore? DeviceAndConnection { get; init; } = default!;

	/// <summary>
	/// <para>Represents Trust Index Subscore.</para>
	/// </summary>
	[JsonPropertyName("bank_account_insights")]
	public Entity.TrustIndexSubscore? BankAccountInsights { get; init; } = default!;

}

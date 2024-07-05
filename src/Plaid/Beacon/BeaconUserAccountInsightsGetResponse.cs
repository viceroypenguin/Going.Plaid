namespace Going.Plaid.Beacon;

/// <summary>
/// <para>The response schema for <c>/beacon/user/account/insights/get</c></para>
/// </summary>
public record BeaconUserAccountInsightsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the associated Beacon User.</para>
	/// </summary>
	[JsonPropertyName("beacon_user_id")]
	public string BeaconUserId { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp. This field indicates the last time the resource was modified.</para>
	/// </summary>
	[JsonPropertyName("updated_at")]
	public DateTimeOffset UpdatedAt { get; init; } = default!;

	/// <summary>
	/// <para>A collection of Bank Accounts linked to an Item that is associated with this Beacon User.</para>
	/// </summary>
	[JsonPropertyName("bank_account_insights")]
	public Entity.BeaconBankAccounts BankAccountInsights { get; init; } = default!;

}

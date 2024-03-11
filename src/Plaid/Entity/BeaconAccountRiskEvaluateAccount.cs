namespace Going.Plaid.Entity;

/// <summary>
/// <para>An account in the <c>/beacon/account_risk/v1/evaluate</c> response.</para>
/// </summary>
public record BeaconAccountRiskEvaluateAccount
{
	/// <summary>
	/// <para>The account ID.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account type schema</a> for a full listing of account types and corresponding subtypes.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.AccountType? Type { get; init; } = default!;

	/// <summary>
	/// <para>See the [Account type schema](https://plaid.com/docs/api/accounts/#account-type-schema) for a full listing of account types and corresponding subtypes.</para>
	/// </summary>
	[JsonPropertyName("subtype")]
	public Entity.AccountSubtype? Subtype { get; init; } = default!;

	/// <summary>
	/// <para>The attributes object contains data that can be used to assess account risk. Examples of data include:</para>
	/// <para><c>days_since_first_plaid_connection</c>: The number of days since the first time the Item was connected to an application via Plaid</para>
	/// <para><c>plaid_connections_count_7d</c>: The number of times the Item has been connected to applications via Plaid over the past 7 days</para>
	/// <para><c>plaid_connections_count_30d</c>: The number of times the Item has been connected to applications via Plaid over the past 30 days</para>
	/// <para><c>total_plaid_connections_count</c>: The number of times the Item has been connected to applications via Plaid</para>
	/// <para>For the full list and detailed documentation of core attributes available, or to request that core attributes not be returned, contact Sales or your Plaid account manager</para>
	/// </summary>
	[JsonPropertyName("attributes")]
	public Entity.BeaconAccountRiskEvaluateAccountAttributes? Attributes { get; init; } = default!;

}

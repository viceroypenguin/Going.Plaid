namespace Going.Plaid.Accounts;

/// <summary>
/// <para>AccountsGetResponse defines the response schema for <c>/accounts/get</c> and <c>/accounts/balance/get</c>.</para>
/// </summary>
public record AccountsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of financial institution accounts associated with the Item.</para>
	/// <para>If <c>/accounts/balance/get</c> was called, each account will include real-time balance information.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.Account> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

	/// <summary>
	/// <para>Provides a detailed risk assessment for the requested transaction. For this field to be returned, the client must be enrolled in the Balance Plus beta program and the <a href="http://plaid.com/docs/balance/balance-plus/#accounts-balance-get-request-payment-details"><c>payment_details</c></a> object must have been sent in the request.</para>
	/// </summary>
	[JsonPropertyName("payment_risk_assessment")]
	public Entity.AccountsBalanceGetResponsePaymentRiskAssessment? PaymentRiskAssessment { get; init; } = default!;

}

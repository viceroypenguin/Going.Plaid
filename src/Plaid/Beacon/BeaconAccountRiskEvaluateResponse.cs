namespace Going.Plaid.Beacon;

/// <summary>
/// <para>BeaconAccountRiskEvaluateResponse defines the response schema for <c>/beacon/account_risk/v1/evaluate</c></para>
/// </summary>
public record BeaconAccountRiskEvaluateResponse : ResponseBase
{
	/// <summary>
	/// <para>The accounts for which a risk evaluation has been requested.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.BeaconAccountRiskEvaluateAccount> Accounts { get; init; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/beacon/account_risk/v1/evaluate</c> results to a subset of the accounts on the linked Item.</para>
/// </summary>
public class BeaconAccountRiskEvaluateRequestOptions
{
	/// <summary>
	/// <para>An array of <c>account_ids</c> for the specific accounts to evaluate.</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string>? AccountIds { get; set; } = default!;

}

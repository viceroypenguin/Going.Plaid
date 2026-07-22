namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about known ACH returns for the account and routing number.</para>
/// </summary>
public record AccountVerificationInsightsPreviousReturns
{
	/// <summary>
	/// <para>Indicates whether Plaid's data sources include a known administrative ACH return for this account and routing number.</para>
	/// </summary>
	[JsonPropertyName("has_previous_administrative_return")]
	public bool HasPreviousAdministrativeReturn { get; init; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>SSL status for the business website.</para>
/// </summary>
public record BusinessWebsiteSSL
{
	/// <summary>
	/// <para>Tri-state boolean status, where <c>no_data</c> indicates the check could not determine a value.</para>
	/// </summary>
	[JsonPropertyName("is_valid")]
	public Entity.BusinessCheckBooleanStatus IsValid { get; init; } = default!;

}

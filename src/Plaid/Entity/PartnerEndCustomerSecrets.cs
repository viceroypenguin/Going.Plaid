namespace Going.Plaid.Entity;

/// <summary>
/// <para>The secrets for the newly created end customer.</para>
/// </summary>
public record PartnerEndCustomerSecrets
{
	/// <summary>
	/// <para>The end customer's secret key for the Production environment.</para>
	/// </summary>
	[JsonPropertyName("production")]
	public string Production { get; init; } = default!;

	/// <summary>
	/// <para>The end customer's secret key for the Sandbox environment.</para>
	/// </summary>
	[JsonPropertyName("sandbox")]
	public string Sandbox { get; init; } = default!;

	/// <summary>
	/// <para>The end customer's secret key for the Development environment.</para>
	/// </summary>
	[JsonPropertyName("development")]
	public string Development { get; init; } = default!;
}
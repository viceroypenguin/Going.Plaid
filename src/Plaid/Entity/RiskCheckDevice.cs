namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying values for <c>device</c> attributes of risk check.</para>
/// </summary>
public record RiskCheckDevice
{
	/// <summary>
	/// <para>An enum indicating whether a network proxy is present and if so what type it is.</para>
	/// </summary>
	[JsonPropertyName("ip_proxy_type")]
	public Entity.ProxyType? IpProxyType { get; init; } = default!;

	/// <summary>
	/// <para>Count of spam lists the IP address is associated with if known.</para>
	/// </summary>
	[JsonPropertyName("ip_spam_list_count")]
	public int? IpSpamListCount { get; init; } = default!;

	/// <summary>
	/// <para>UTC offset of the timezone associated with the IP address.</para>
	/// </summary>
	[JsonPropertyName("ip_timezone_offset")]
	public string? IpTimezoneOffset { get; init; } = default!;

	/// <summary>
	/// <para>Risk level for the given risk check type.</para>
	/// </summary>
	[JsonPropertyName("risk_level")]
	public Entity.RiskLevel? RiskLevel { get; init; } = default!;

	/// <summary>
	/// <para>List of factors, when available, that contribute towards the risk level of the given risk check type.</para>
	/// </summary>
	[JsonPropertyName("factors")]
	public IReadOnlyList<string>? Factors { get; init; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the end user's device. These fields are optional, but strongly recommended to increase the accuracy of results when using Signal Transaction Scores. When using a Balance-only Ruleset, these fields are ignored if the Signal Addendum has been signed; if it has not been signed, using these fields will result in an error.</para>
/// </summary>
public class SignalEvaluateDevice
{
	/// <summary>
	/// <para>The IP address of the device that initiated the transaction</para>
	/// </summary>
	[JsonPropertyName("ip_address")]
	public string? IpAddress { get; set; } = default!;

	/// <summary>
	/// <para>The user agent of the device that initiated the transaction (e.g. "Mozilla/5.0")</para>
	/// </summary>
	[JsonPropertyName("user_agent")]
	public string? UserAgent { get; set; } = default!;

}

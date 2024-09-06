namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata related to the acceptance of Terms of Service</para>
/// </summary>
public class TOSAcceptanceMetadata
{
	/// <summary>
	/// <para>Indicates whether the TOS agreement was accepted</para>
	/// </summary>
	[JsonPropertyName("agreement_accepted")]
	public bool AgreementAccepted { get; set; } = default!;

	/// <summary>
	/// <para>The IP address of the originator when they accepted the TOS. Formatted as an IPv4 or IPv6 IP address</para>
	/// </summary>
	[JsonPropertyName("originator_ip_address")]
	public string OriginatorIpAddress { get; set; } = default!;

	/// <summary>
	/// <para>ISO8601 timestamp indicating when the originator accepted the TOS</para>
	/// </summary>
	[JsonPropertyName("agreement_accepted_at")]
	public DateTimeOffset AgreementAcceptedAt { get; set; } = default!;

}

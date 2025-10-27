namespace Going.Plaid.Entity;

/// <summary>
/// <para>The bank addendum acceptance for the end customer.</para>
/// </summary>
public class PartnerEndCustomerBankAddendumAcceptance
{
	/// <summary>
	/// <para>Denotes whether the end customer has accepted the bank addendum terms.</para>
	/// </summary>
	[JsonPropertyName("customer_accepted")]
	public bool? CustomerAccepted { get; set; } = default!;

	/// <summary>
	/// <para>The IP address of the end customer when they accepted the bank addendum.</para>
	/// </summary>
	[JsonPropertyName("customer_ip_address")]
	public string? CustomerIpAddress { get; set; } = default!;

	/// <summary>
	/// <para>The timestamp of when the end customer accepted the bank addendum in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>).</para>
	/// </summary>
	[JsonPropertyName("customer_agreement_timestamp")]
	public DateTimeOffset? CustomerAgreementTimestamp { get; set; } = default!;

}

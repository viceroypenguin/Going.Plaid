namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the device being used to initiate the authorization. These fields are not currently incorporated into the risk check.</para>
/// </summary>
public class TransferAuthorizationDevice
{
	/// <summary>
	/// <para>The IP address of the device being used to initiate the authorization.</para>
	/// </summary>
	[JsonPropertyName("ip_address")]
	public string? IpAddress { get; set; } = default!;

	/// <summary>
	/// <para>The user agent of the device being used to initiate the authorization.</para>
	/// </summary>
	[JsonPropertyName("user_agent")]
	public string? UserAgent { get; set; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>An enum indicating whether a network proxy is present and if so what type it is.</para>
/// </summary>
public enum ProxyType
{
	/// <summary>
	/// <para>indicates the user is not on a detectable proxy network.</para>
	/// </summary>
	[EnumMember(Value = "none_detected")]
	NoneDetected,

	/// <summary>
	/// <para>indicates the user was using a Tor browser, which sends encrypted traffic on a decentralized network and is somewhat similar to a VPN (Virtual Private Network).</para>
	/// </summary>
	[EnumMember(Value = "tor")]
	Tor,

	/// <summary>
	/// <para>indicates the user is on a VPN (Virtual Private Network)</para>
	/// </summary>
	[EnumMember(Value = "vpn")]
	Vpn,

	/// <summary>
	/// <para>indicates the user is on a web proxy server, which may allow them to conceal information such as their IP address or other identifying information.</para>
	/// </summary>
	[EnumMember(Value = "web_proxy")]
	WebProxy,

	/// <summary>
	/// <para>indicates the user is on a public web proxy server, which is similar to a web proxy but can be shared by multiple users. This may allow multiple users to appear as if they have the same IP address for instance.</para>
	/// </summary>
	[EnumMember(Value = "public_proxy")]
	PublicProxy,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

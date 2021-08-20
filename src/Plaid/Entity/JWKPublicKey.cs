namespace Going.Plaid.Entity;

/// <summary>
/// <para>A JSON Web Key (JWK) that can be used in conjunction with <a href="https://jwt.io/#libraries-io">JWT libraries</a> to verify Plaid webhooks</para>
/// </summary>
public record JWKPublicKey
{
	/// <summary>
	/// <para>The alg member identifies the cryptographic algorithm family used with the key.</para>
	/// </summary>
	[JsonPropertyName("alg")]
	public string Alg { get; init; } = default!;

	/// <summary>
	/// <para>The crv member identifies the cryptographic curve used with the key.</para>
	/// </summary>
	[JsonPropertyName("crv")]
	public string Crv { get; init; } = default!;

	/// <summary>
	/// <para>The kid (Key ID) member can be used to match a specific key. This can be used, for instance, to choose among a set of keys within the JWK during key rollover.</para>
	/// </summary>
	[JsonPropertyName("kid")]
	public string Kid { get; init; } = default!;

	/// <summary>
	/// <para>The kty (key type) parameter identifies the cryptographic algorithm family used with the key, such as RSA or EC.</para>
	/// </summary>
	[JsonPropertyName("kty")]
	public string Kty { get; init; } = default!;

	/// <summary>
	/// <para>The use (public key use) parameter identifies the intended use of the public key.</para>
	/// </summary>
	[JsonPropertyName("use")]
	public string Use { get; init; } = default!;

	/// <summary>
	/// <para>The x member contains the x coordinate for the elliptic curve point.</para>
	/// </summary>
	[JsonPropertyName("x")]
	public string X { get; init; } = default!;

	/// <summary>
	/// <para>The y member contains the y coordinate for the elliptic curve point.</para>
	/// </summary>
	[JsonPropertyName("y")]
	public string Y { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("created_at")]
	public int CreatedAt { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("expired_at")]
	public int? ExpiredAt { get; init; } = default!;
}
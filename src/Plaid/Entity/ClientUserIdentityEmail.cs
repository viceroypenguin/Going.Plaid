namespace Going.Plaid.Entity;

/// <summary>
/// <para>User email information.</para>
/// </summary>
public class ClientUserIdentityEmail
{
	/// <summary>
	/// <para>User's email.</para>
	/// </summary>
	[JsonPropertyName("data")]
	public string Data { get; set; } = default!;

	/// <summary>
	/// <para>Indicates whether this is the primary email for the User.</para>
	/// </summary>
	[JsonPropertyName("primary")]
	public bool Primary { get; set; } = default!;

}

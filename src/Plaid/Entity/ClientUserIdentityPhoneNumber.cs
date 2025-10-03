namespace Going.Plaid.Entity;

/// <summary>
/// <para>User phone number information.</para>
/// </summary>
public class ClientUserIdentityPhoneNumber
{
	/// <summary>
	/// <para>User's phone number.</para>
	/// </summary>
	[JsonPropertyName("data")]
	public string Data { get; set; } = default!;

	/// <summary>
	/// <para>Indicates whether this is the primary phone number for the User.</para>
	/// </summary>
	[JsonPropertyName("primary")]
	public bool Primary { get; set; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object specifying information about the end user for the network status check.</para>
/// </summary>
public class NetworkStatusGetUser
{
	/// <summary>
	/// <para>The user's phone number in <a href="https://en.wikipedia.org/wiki/E.164">E.164</a> format.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string PhoneNumber { get; set; } = default!;

}

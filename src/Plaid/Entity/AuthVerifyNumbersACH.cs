namespace Going.Plaid.Entity;

/// <summary>
/// <para>ACH numbers for verification via Database Auth</para>
/// </summary>
public class AuthVerifyNumbersACH
{
	/// <summary>
	/// <para>Account's account number</para>
	/// </summary>
	[JsonPropertyName("account")]
	public string Account { get; set; } = default!;

	/// <summary>
	/// <para>Account's routing number</para>
	/// </summary>
	[JsonPropertyName("routing")]
	public string Routing { get; set; } = default!;

}

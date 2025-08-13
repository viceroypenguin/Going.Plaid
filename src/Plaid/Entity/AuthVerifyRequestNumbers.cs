namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing identifying account numbers for verification via Database Auth</para>
/// </summary>
public class AuthVerifyRequestNumbers
{
	/// <summary>
	/// <para>ACH numbers for verification via Database Auth</para>
	/// </summary>
	[JsonPropertyName("ach")]
	public Entity.AuthVerifyNumbersACH Ach { get; set; } = default!;

}

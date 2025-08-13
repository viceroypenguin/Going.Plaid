namespace Going.Plaid.Auth;

/// <summary>
/// <para>AuthVerifyRequest defines the request schema for <c>/auth/verify</c></para>
/// </summary>
public partial class AuthVerifyRequest : RequestBase
{
	/// <summary>
	/// <para>Account owner's legal name</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string? LegalName { get; set; } = default!;

	/// <summary>
	/// <para>An object containing identifying account numbers for verification via Database Auth</para>
	/// </summary>
	[JsonPropertyName("numbers")]
	public Entity.AuthVerifyRequestNumbers Numbers { get; set; } = default!;

}

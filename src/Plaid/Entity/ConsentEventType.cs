namespace Going.Plaid.Entity;

/// <summary>
/// <para>A broad categorization of the consent event.</para>
/// </summary>
public enum ConsentEventType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CONSENT_GRANTED")]
	ConsentGranted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CONSENT_REVOKED")]
	ConsentRevoked,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CONSENT_UPDATED")]
	ConsentUpdated,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

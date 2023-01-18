namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public enum ServiceProductFulfillmentIdentifier
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VOA")]
	Voa,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VOETRANSACTIONS")]
	Voetransactions,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
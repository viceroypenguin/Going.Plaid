namespace Going.Plaid.Entity;

/// <summary>
/// <para>The delivery method to be used to deliver the Hosted Link session URL.</para>
/// </summary>
public enum LinkDeliveryDeliveryMethod
{
	/// <summary>
	/// <para>The URL will be delivered through SMS</para>
	/// </summary>
	[EnumMember(Value = "SMS")]
	Sms,

	/// <summary>
	/// <para>The URL will be delivered through email</para>
	/// </summary>
	[EnumMember(Value = "EMAIL")]
	Email,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
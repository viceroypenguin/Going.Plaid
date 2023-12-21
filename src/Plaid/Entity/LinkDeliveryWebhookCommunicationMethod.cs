namespace Going.Plaid.Entity;

/// <summary>
/// <para>The communication method used to deliver the Hosted Link session</para>
/// </summary>
public enum LinkDeliveryWebhookCommunicationMethod
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SMS")]
	Sms,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EMAIL")]
	Email,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
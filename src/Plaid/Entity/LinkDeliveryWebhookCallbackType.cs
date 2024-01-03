namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of Link callback event</para>
/// </summary>
public enum LinkDeliveryWebhookCallbackType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ON_SUCCESS")]
	OnSuccess,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ON_EVENT")]
	OnEvent,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ON_EXIT")]
	OnExit,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

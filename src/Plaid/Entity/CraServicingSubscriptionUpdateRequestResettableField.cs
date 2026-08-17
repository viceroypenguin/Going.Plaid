namespace Going.Plaid.Entity;

/// <summary>
/// <para>The name of a field that can be reset back to its default value.</para>
/// </summary>
public enum CraServicingSubscriptionUpdateRequestResettableField
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "webhook")]
	Webhook,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the given Link Delivery Session.</para>
/// </summary>
public enum LinkDeliverySessionStatus
{
	/// <summary>
	/// <para>The session is created but not yet accessed by the user</para>
	/// </summary>
	[EnumMember(Value = "CREATED")]
	Created,

	/// <summary>
	/// <para>The session is opened by the user but not yet completed</para>
	/// </summary>
	[EnumMember(Value = "OPENED")]
	Opened,

	/// <summary>
	/// <para>The session has been completed by the user</para>
	/// </summary>
	[EnumMember(Value = "COMPLETED")]
	Completed,

	/// <summary>
	/// <para>The session has expired</para>
	/// </summary>
	[EnumMember(Value = "EXPIRED")]
	Expired,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
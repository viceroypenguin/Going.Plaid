namespace Going.Plaid.Entity;

/// <summary>
/// <para>A customer-visible effect of an issue.</para>
/// </summary>
public enum BetaIssuesV1IssueBehavior
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NEW_CONNECTIONS_CANNOT_BE_ESTABLISHED")]
	NewConnectionsCannotBeEstablished,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EXISTING_CONNECTIONS_WILL_NOT_RECEIVE_UPDATES")]
	ExistingConnectionsWillNotReceiveUpdates,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EXISTING_CONNECTIONS_WILL_BE_DISCONNECTED")]
	ExistingConnectionsWillBeDisconnected,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

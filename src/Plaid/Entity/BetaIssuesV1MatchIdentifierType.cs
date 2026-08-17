namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of identifier supplied to <c>/beta/issues/v1/match</c>.</para>
/// </summary>
public enum BetaIssuesV1MatchIdentifierType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_ID")]
	ItemId,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "REQUEST_ID")]
	RequestId,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LINK_SESSION_ID")]
	LinkSessionId,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ACCOUNT_ID")]
	AccountId,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

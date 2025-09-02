namespace Going.Plaid.Entity;

/// <summary>
/// <para>The reason for removing the item</para>
/// </summary>
public enum ItemRemoveReasonCode
{
	/// <summary>
	/// <para>The end user who owns the connected bank account committed fraud</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_FIRST_PARTY")]
	FraudFirstParty,

	/// <summary>
	/// <para>The end user created the connection using false identity information or stolen credentials</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_FALSE_IDENTITY")]
	FraudFalseIdentity,

	/// <summary>
	/// <para>The end user is abusing the client's service or platform through their connected account</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_ABUSE")]
	FraudAbuse,

	/// <summary>
	/// <para>Other fraud-related reasons involving the end user not covered by the specific fraud categories</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_OTHER")]
	FraudOther,

	/// <summary>
	/// <para>The connection to the end user's financial institution is broken and cannot be restored</para>
	/// </summary>
	[EnumMember(Value = "CONNECTION_IS_NON_FUNCTIONAL")]
	ConnectionIsNonFunctional,

	/// <summary>
	/// <para>Any other reason for removing the connection not covered by the above categories</para>
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

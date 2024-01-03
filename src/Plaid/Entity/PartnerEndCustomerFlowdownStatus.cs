namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the addendum to the Plaid MSA ("flowdown") for the end customer.</para>
/// </summary>
public enum PartnerEndCustomerFlowdownStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NOT_STARTED")]
	NotStarted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IN_REVIEW")]
	InReview,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NEGOTIATION")]
	Negotiation,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "COMPLETE")]
	Complete,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

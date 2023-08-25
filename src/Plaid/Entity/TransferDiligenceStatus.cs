namespace Going.Plaid.Entity;

/// <summary>
/// <para>Originator’s diligence status.</para>
/// </summary>
public enum TransferDiligenceStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "not_submitted")]
	NotSubmitted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "submitted")]
	Submitted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "under_review")]
	UnderReview,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "approved")]
	Approved,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "denied")]
	Denied,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
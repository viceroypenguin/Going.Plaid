namespace Going.Plaid.Entity;

/// <summary>
/// <para>A decision regarding the proposed transfer.</para>
/// </summary>
public enum TransferAuthorizationDecisionEnum
{
	/// <summary>
	/// <para>– The proposed transfer has received the end user's consent and has been approved for processing. Plaid has also reviewed the proposed transfer and has approved it for processing.</para>
	/// </summary>
	[EnumMember(Value = "approved")]
	Approved,

	/// <summary>
	/// <para>– Plaid was unable to fetch the information required to approve or decline the proposed transfer. You may proceed with the transfer, but further review is recommended. Plaid is awaiting further instructions from the client.</para>
	/// </summary>
	[EnumMember(Value = "permitted")]
	Permitted,

	/// <summary>
	/// <para>– Plaid reviewed the proposed transfer and declined processing. Refer to the <c>code</c> field in the <c>decision_rationale</c> object for details.</para>
	/// </summary>
	[EnumMember(Value = "declined")]
	Declined,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}
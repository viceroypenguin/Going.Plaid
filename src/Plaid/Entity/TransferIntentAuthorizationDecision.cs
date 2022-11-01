namespace Going.Plaid.Entity;

/// <summary>
/// <para>A decision regarding the proposed transfer.</para>
/// </summary>
public enum TransferIntentAuthorizationDecision
{
	/// <summary>
	/// <para>– The proposed transfer has received the end user's consent and has been approved for processing by Plaid. The <c>decision_rationale</c> field is set if Plaid was unable to fetch the account information. You may proceed with the transfer, but further review is recommended (i.e., use Link in update to re-authenticate your user when <c>decision_rationale.code</c> is <c>ITEM_LOGIN_REQUIRED</c>). Refer to the <c>code</c> field in the <c>decision_rationale</c> object for details.</para>
	/// </summary>
	[EnumMember(Value = "APPROVED")]
	Approved,

	/// <summary>
	/// <para>– Plaid reviewed the proposed transfer and declined processing. Refer to the <c>code</c> field in the <c>decision_rationale</c> object for details.</para>
	/// </summary>
	[EnumMember(Value = "DECLINED")]
	Declined,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
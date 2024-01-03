namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates whether the transfer is guaranteed by Plaid (Guarantee customers only). This field will contain either <c>GUARANTEED</c> or <c>NOT_GUARANTEED</c> indicating whether Plaid will guarantee the transfer. If the transfer is not guaranteed, additional information will be provided in the <c>guarantee_decision_rationale</c> field. Refer to the <c>code</c> field in <c>guarantee_decision_rationale</c> for details.</para>
/// </summary>
public enum TransferAuthorizationGuaranteeDecision
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "GUARANTEED")]
	Guaranteed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NOT_GUARANTEED")]
	NotGuaranteed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

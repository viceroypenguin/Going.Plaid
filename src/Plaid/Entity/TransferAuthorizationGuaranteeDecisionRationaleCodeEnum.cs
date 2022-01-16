namespace Going.Plaid.Entity;

/// <summary>
/// <para>A code representing the reason Plaid declined to guarantee this transfer:</para>
/// </summary>
public enum TransferAuthorizationGuaranteeDecisionRationaleCodeEnum
{
	/// <summary>
	/// <para>The risk of a bank-initiated return (for example, an R01/NSF) is too high to guarantee this transfer.</para>
	/// </summary>
	[EnumMember(Value = "RETURN_BANK")]
	ReturnBank,

	/// <summary>
	/// <para>The risk of a customer-initiated return (for example, a R10/Unauthorized) is too high to guarantee this transfer.</para>
	/// </summary>
	[EnumMember(Value = "RETURN_CUSTOMER")]
	ReturnCustomer,

	/// <summary>
	/// <para>This transfer is low-risk, but Guaranteed ACH has exhausted an internal limit on the number or rate of guarantees that applies to this transfer.</para>
	/// </summary>
	[EnumMember(Value = "GUARANTEE_LIMIT_REACHED")]
	GuaranteeLimitReached,

	/// <summary>
	/// <para>A risk estimate is unavailable for this Item.</para>
	/// </summary>
	[EnumMember(Value = "RISK_ESTIMATE_UNAVAILABLE")]
	RiskEstimateUnavailable,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
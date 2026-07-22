namespace Going.Plaid.Entity;

/// <summary>
/// <para>The permissible purpose under the FCRA for retrieving this consumer report. Restricted to permissible purposes related to loan servicing only. Required when <c>report_id</c> is provided.</para>
/// </summary>
public enum CraCheckReportPermissiblePurpose
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ACCOUNT_REVIEW_CREDIT")]
	AccountReviewCredit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "WRITTEN_INSTRUCTION_OTHER")]
	WrittenInstructionOther,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

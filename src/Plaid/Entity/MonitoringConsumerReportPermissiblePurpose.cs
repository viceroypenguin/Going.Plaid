namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes the reason you are generating a Consumer Report for this user.</para>
/// </summary>
public enum MonitoringConsumerReportPermissiblePurpose
{
	/// <summary>
	/// <para>In connection with a consumer credit transaction for the review or collection of an account pursuant to FCRA Section 604(a)(3)(A).</para>
	/// </summary>
	[EnumMember(Value = "ACCOUNT_REVIEW_CREDIT")]
	AccountReviewCredit,

	/// <summary>
	/// <para>In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), such as when an individual agrees to act as a guarantor or assumes personal liability for a consumer, business, or commercial loan.</para>
	/// </summary>
	[EnumMember(Value = "WRITTEN_INSTRUCTION_OTHER")]
	WrittenInstructionOther,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

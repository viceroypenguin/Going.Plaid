namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies the source of funds for the transfer. Only valid for <c>credit</c> transfers, and defaults to <c>sweep</c> if not specified. This field is not specified for <c>debit</c> transfers.</para>
/// </summary>
public enum TransferCreditFundsSource
{
	/// <summary>
	/// <para>Sweep funds from your funding account</para>
	/// </summary>
	[EnumMember(Value = "sweep")]
	Sweep,

	/// <summary>
	/// <para>Use your prefunded RTP credit balance with Plaid</para>
	/// </summary>
	[EnumMember(Value = "prefunded_rtp_credits")]
	PrefundedRtpCredits,

	/// <summary>
	/// <para>Use your prefunded ACH credit balance with Plaid</para>
	/// </summary>
	[EnumMember(Value = "prefunded_ach_credits")]
	PrefundedAchCredits,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
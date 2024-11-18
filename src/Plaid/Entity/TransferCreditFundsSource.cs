namespace Going.Plaid.Entity;

/// <summary>
/// <para>This field is now deprecated. You may ignore it for transfers created on and after 12/01/2023.</para>
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

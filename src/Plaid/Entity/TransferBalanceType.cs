namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of balance.</para>
/// </summary>
public enum TransferBalanceType
{
	/// <summary>
	/// <para>Your prefunded RTP credit balance with Plaid</para>
	/// </summary>
	[EnumMember(Value = "prefunded_rtp_credits")]
	PrefundedRtpCredits,

	/// <summary>
	/// <para>Your prefunded ACH credit balance with Plaid</para>
	/// </summary>
	[EnumMember(Value = "prefunded_ach_credits")]
	PrefundedAchCredits,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
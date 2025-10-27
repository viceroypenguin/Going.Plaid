namespace Going.Plaid.Entity;

/// <summary>
/// <para>The source that identified or reported the incident.</para>
/// </summary>
public enum ProtectReportSource
{
	/// <summary>
	/// <para>Incident was identified through internal fraud investigations or review processes.</para>
	/// </summary>
	[EnumMember(Value = "INTERNAL_REVIEW")]
	InternalReview,

	/// <summary>
	/// <para>Incident was reported directly by the affected user.</para>
	/// </summary>
	[EnumMember(Value = "USER_SELF_REPORTED")]
	UserSelfReported,

	/// <summary>
	/// <para>Incident was identified through bank feedback, including ACH returns and connection revocations.</para>
	/// </summary>
	[EnumMember(Value = "BANK_FEEDBACK")]
	BankFeedback,

	/// <summary>
	/// <para>Incident was identified through card network alerts or chargebacks.</para>
	/// </summary>
	[EnumMember(Value = "NETWORK_FEEDBACK")]
	NetworkFeedback,

	/// <summary>
	/// <para>Incident was detected by automated systems such as fraud models or rule engines.</para>
	/// </summary>
	[EnumMember(Value = "AUTOMATED_SYSTEM")]
	AutomatedSystem,

	/// <summary>
	/// <para>Incident was identified through external vendor or consortium alerts.</para>
	/// </summary>
	[EnumMember(Value = "THIRD_PARTY_ALERT")]
	ThirdPartyAlert,

	/// <summary>
	/// <para>Incident was identified through a source not covered by other categories.</para>
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

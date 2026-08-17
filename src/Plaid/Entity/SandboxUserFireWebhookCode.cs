namespace Going.Plaid.Entity;

/// <summary>
/// <para>The webhook codes that can be fired by this test endpoint.</para>
/// </summary>
public enum SandboxUserFireWebhookCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "USER_CHECK_REPORT_READY")]
	UserCheckReportReady,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "USER_CHECK_REPORT_FAILED")]
	UserCheckReportFailed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CHECK_REPORT_READY")]
	CheckReportReady,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CHECK_REPORT_FAILED")]
	CheckReportFailed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

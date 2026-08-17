namespace Going.Plaid.Entity;

/// <summary>
/// <para>The webhook types that can be fired by this test endpoint.</para>
/// </summary>
public enum SandboxUserFireWebhookType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CHECK_REPORT")]
	CheckReport,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>The OAuth status of the update</para>
/// </summary>
public enum PartnerEndCustomerOAuthStatusUpdatedValues
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "not-started")]
	NotStarted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "processing")]
	Processing,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "approved")]
	Approved,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "enabled")]
	Enabled,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "attention-required")]
	AttentionRequired,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

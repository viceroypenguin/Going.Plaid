namespace Going.Plaid.Entity;

/// <summary>
/// <para>The registration status for the end customer's application.</para>
/// </summary>
public enum PartnerEndCustomerOAuthInstitutionApplicationStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NOT_STARTED")]
	NotStarted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PROCESSING")]
	Processing,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "APPROVED")]
	Approved,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ENABLED")]
	Enabled,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ATTENTION_REQUIRED")]
	AttentionRequired,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

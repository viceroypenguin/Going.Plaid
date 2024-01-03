namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the end customer's security questionnaire.</para>
/// </summary>
public enum PartnerEndCustomerQuestionnaireStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NOT_STARTED")]
	NotStarted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RECEIVED")]
	Received,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "COMPLETE")]
	Complete,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>Description of the reason you want to evaluate risk.</para>
/// </summary>
public enum BeaconAccountRiskEvaluateEvaluationReason
{
	/// <summary>
	/// <para>user links a first bank account as part of the onboarding flow of your platform.</para>
	/// </summary>
	[EnumMember(Value = "ONBOARDING")]
	Onboarding,

	/// <summary>
	/// <para>user links another bank account or replaces the currently linked bank account on your platform.</para>
	/// </summary>
	[EnumMember(Value = "NEW_ACCOUNT")]
	NewAccount,

	/// <summary>
	/// <para>user changes their information on your platform, e.g., updating their phone number.</para>
	/// </summary>
	[EnumMember(Value = "INFORMATION_CHANGE")]
	InformationChange,

	/// <summary>
	/// <para>you decide to re-evaluate a user that becomes active after a period of inactivity.</para>
	/// </summary>
	[EnumMember(Value = "DORMANT_USER")]
	DormantUser,

	/// <summary>
	/// <para>any other reasons not listed here</para>
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>The frequency at which payments are scheduled.</para>
/// </summary>
public enum LoanPaymentFrequency
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "daily")]
	Daily,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "weekly")]
	Weekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "biweekly")]
	Biweekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "semimonthly")]
	Semimonthly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "monthly")]
	Monthly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "semiannually")]
	Semiannually,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "annually")]
	Annually,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

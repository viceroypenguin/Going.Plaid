namespace Going.Plaid.Entity;

/// <summary>
/// <para>The frequency of a loan's payment schedule.</para>
/// </summary>
public enum CraLoanPaymentSchedule
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DAILY")]
	Daily,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "WEEKLY")]
	Weekly,

	/// <summary>
	/// <para>represents one payment every two weeks.</para>
	/// </summary>
	[EnumMember(Value = "BIWEEKLY")]
	Biweekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MONTHLY")]
	Monthly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "QUARTERLY")]
	Quarterly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ANNUALLY")]
	Annually,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

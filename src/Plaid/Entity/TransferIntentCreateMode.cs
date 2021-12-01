namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum TransferIntentCreateMode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT")]
	Payment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DISBURSEMENT")]
	Disbursement,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
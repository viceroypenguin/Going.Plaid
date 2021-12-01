namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the transfer intent.</para>
/// </summary>
public enum TransferIntentGetResponseStatusEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PENDING")]
	Pending,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SUCCEEDED")]
	Succeeded,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FAILED")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
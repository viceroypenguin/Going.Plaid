namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the transfer intent.</para>
/// </summary>
public enum TransferIntentStatus
{
	/// <summary>
	/// <para>The transfer intent is pending.</para>
	/// </summary>
	[EnumMember(Value = "PENDING")]
	Pending,

	/// <summary>
	/// <para>The transfer intent was successfully created.</para>
	/// </summary>
	[EnumMember(Value = "SUCCEEDED")]
	Succeeded,

	/// <summary>
	/// <para>The transfer intent was unable to be created.</para>
	/// </summary>
	[EnumMember(Value = "FAILED")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>The current status of the transaction stream.</para>
/// </summary>
public enum TransactionStreamStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MATURE")]
	Mature,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EARLY_DETECTION")]
	EarlyDetection,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TOMBSTONED")]
	Tombstoned,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
namespace Going.Plaid.Entity;

/// <summary>
/// <para>Status of a document for risk signal analysis</para>
/// </summary>
public enum RiskSignalDocumentStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PROCESSING")]
	Processing,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PROCESSING_COMPLETE")]
	ProcessingComplete,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PROCESSING_ERROR")]
	ProcessingError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PASSWORD_PROTECTED")]
	PasswordProtected,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VIRUS_DETECTED")]
	VirusDetected,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

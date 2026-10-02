namespace Going.Plaid.Entity;

/// <summary>
/// <para>The reason every product in a CRA report failed to generate. <c>null</c> when at least one product succeeded.</para>
/// </summary>
public enum CraReportErrorCode
{
	/// <summary>
	/// <para>Plaid could not retrieve enough data from the user's Items to generate any of the requested products. Sending the user through Link to add or repair Items may resolve this.</para>
	/// </summary>
	[EnumMember(Value = "DATA_UNAVAILABLE")]
	DataUnavailable,

	/// <summary>
	/// <para>Plaid encountered an unexpected error while generating the report.</para>
	/// </summary>
	[EnumMember(Value = "INTERNAL_SERVER_ERROR")]
	InternalServerError,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

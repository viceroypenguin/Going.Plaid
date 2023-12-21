namespace Going.Plaid.Entity;

/// <summary>
/// <para>The result of the statement refresh extraction</para>
/// </summary>
public enum StatementsRefreshCompleteResult
{
	/// <summary>
	/// <para>The statements were successfully extracted and can be listed via <c>/statements/list/</c> and downloaded via <c>/statements/download/</c>.</para>
	/// </summary>
	[EnumMember(Value = "SUCCESS")]
	Success,

	/// <summary>
	/// <para>The statements failed to be extracted.</para>
	/// </summary>
	[EnumMember(Value = "FAILURE")]
	Failure,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
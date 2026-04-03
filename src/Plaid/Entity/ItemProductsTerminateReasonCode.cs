namespace Going.Plaid.Entity;

/// <summary>
/// <para>The reason for terminating products on the Item.</para>
/// </summary>
public enum ItemProductsTerminateReasonCode
{
	/// <summary>
	/// <para>Any other reason for terminating products not covered by the above categories</para>
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

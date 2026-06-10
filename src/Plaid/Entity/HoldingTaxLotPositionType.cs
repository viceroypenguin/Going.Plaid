namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates whether a holding lot position is long or short. Possible values are <c>LONG</c> and <c>SHORT</c>.</para>
/// </summary>
public enum HoldingTaxLotPositionType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LONG")]
	Long,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SHORT")]
	Short,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

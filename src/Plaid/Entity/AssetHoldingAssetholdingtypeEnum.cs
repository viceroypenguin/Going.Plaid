namespace Going.Plaid.Entity;

/// <summary>
/// <para>Type of holding (e.g. bond, stock, crypto, other)</para>
/// </summary>
public enum AssetHoldingAssetholdingtypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Bond")]
	Bond,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Stock")]
	Stock,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Crypto")]
	Crypto,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Other")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>How an asset is owned.</para>
/// </summary>
public enum OwnershipType
{
	/// <summary>
	/// <para>Ownership by an individual.</para>
	/// </summary>
	[EnumMember(Value = "individual")]
	Individual,

	/// <summary>
	/// <para>Joint ownership by multiple parties.</para>
	/// </summary>
	[EnumMember(Value = "joint")]
	Joint,

	/// <summary>
	/// <para>Ownership by a corporation, partnership, or unincorporated association, including for-profit and not-for-profit organizations.</para>
	/// </summary>
	[EnumMember(Value = "association")]
	Association,

	/// <summary>
	/// <para>Ownership by a revocable or irrevocable trust.</para>
	/// </summary>
	[EnumMember(Value = "trust")]
	Trust,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

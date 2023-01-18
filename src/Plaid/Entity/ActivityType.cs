namespace Going.Plaid.Entity;

/// <summary>
/// <para>Types of consent activities</para>
/// </summary>
public enum ActivityType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_CREATE")]
	ItemCreate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_IMPORT")]
	ItemImport,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_UPDATE")]
	ItemUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_UNLINK")]
	ItemUnlink,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PORTAL_UNLINK")]
	PortalUnlink,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PORTAL_ITEMS_DELETE")]
	PortalItemsDelete,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_REMOVE")]
	ItemRemove,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVARIANT_CHECKER_DELETION")]
	InvariantCheckerDeletion,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SCOPES_UPDATE")]
	ScopesUpdate,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
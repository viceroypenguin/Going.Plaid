namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates whether an Item requires user interaction to be updated, which can be the case for Items with some forms of two-factor authentication.</para>
/// </summary>
public enum ItemUpdateTypeEnum
{
	/// <summary>
	/// <para>Item can be updated in the background</para>
	/// </summary>
	[EnumMember(Value = "background")]
	Background,

	/// <summary>
	/// <para>Item requires user interaction to be updated</para>
	/// </summary>
	[EnumMember(Value = "user_present_required")]
	UserPresentRequired,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
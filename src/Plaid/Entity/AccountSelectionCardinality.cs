namespace Going.Plaid.Entity;

/// <summary>
/// <para>The application requires that accounts be limited to a specific cardinality.</para>
/// </summary>
public enum AccountSelectionCardinality
{
	/// <summary>
	/// <para>indicates that the user should be allowed to pick only a single account.</para>
	/// </summary>
	[EnumMember(Value = "SINGLE_SELECT")]
	SingleSelect,

	/// <summary>
	/// <para>indicates that the user should be allowed to pick multiple accounts.</para>
	/// </summary>
	[EnumMember(Value = "MULTI_SELECT")]
	MultiSelect,

	/// <summary>
	/// <para>indicates that the user must share all of their accounts and should not be given the opportunity to de-select</para>
	/// </summary>
	[EnumMember(Value = "ALL")]
	All,
}
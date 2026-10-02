namespace Going.Plaid.Entity;

/// <summary>
/// <para>Whether Plaid supports creating new Items for the institution.</para>
/// </summary>
public enum InstitutionConnectionAvailability
{
	/// <summary>
	/// <para>Plaid supports new connections to the institution. Whether a given connection succeeds can still depend on your integration and account: some institutions require completing <a href="https://plaid.com/docs/link/oauth/#complete-the-registration-requirements">OAuth registration</a> before they can be used, the institution may not support every product requested in <c>/link/token/create</c>, and your Plaid account must be in good standing.</para>
	/// </summary>
	[EnumMember(Value = "SUPPORTED")]
	Supported,

	/// <summary>
	/// <para>Plaid does not support new connections to the institution. Existing Items may continue to work. Attempting to create a new Item for the institution returns an <c>INSTITUTION_NO_LONGER_SUPPORTED</c> error. Institutions with this value are returned only by <c>/institutions/get_by_id</c>.</para>
	/// </summary>
	[EnumMember(Value = "NOT_SUPPORTED")]
	NotSupported,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

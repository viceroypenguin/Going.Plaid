namespace Going.Plaid.Entity;

/// <summary>
/// <para>A type indicating what caused a resource to be changed or updated.</para>
/// </summary>
public enum BeaconAuditTrailSource
{
	/// <summary>
	/// <para>The resource was created or updated by a member of your team via the Plaid dashboard.</para>
	/// </summary>
	[EnumMember(Value = "dashboard")]
	Dashboard,

	/// <summary>
	/// <para>The resource was created or updated via the Plaid API.</para>
	/// </summary>
	[EnumMember(Value = "api")]
	Api,

	/// <summary>
	/// <para>The resource was created or updated automatically by a part of the Plaid Beacon system. For example, if another business using Plaid Beacon created a fraud report that matched one of your users, your matching user's status would automatically be updated and the audit trail source would be <c>system</c>.</para>
	/// </summary>
	[EnumMember(Value = "system")]
	System,

	/// <summary>
	/// <para>The resource was created or updated as part of a bulk import process. For example, if your company provided a CSV of user data as part of your initial onboarding, the audit trail source would be <c>bulk_import</c>.</para>
	/// </summary>
	[EnumMember(Value = "bulk_import")]
	BulkImport,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

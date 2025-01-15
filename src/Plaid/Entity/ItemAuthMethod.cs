namespace Going.Plaid.Entity;

/// <summary>
/// <para>The method used to populate Auth data for the Item. This field is only populated for Items that have had Auth numbers data set on at least one of its accounts, and will be <c>null</c> otherwise. For info about the various flows, see our <a href="https://plaid.com/docs/auth/coverage/">Auth coverage documentation</a>.</para>
/// </summary>
public enum ItemAuthMethod
{
	/// <summary>
	/// <para>The Item's Auth data was provided directly by the user's institution connection.</para>
	/// </summary>
	[EnumMember(Value = "INSTANT_AUTH")]
	InstantAuth,

	/// <summary>
	/// <para>The Item's Auth data was provided via the Instant Match fallback flow.</para>
	/// </summary>
	[EnumMember(Value = "INSTANT_MATCH")]
	InstantMatch,

	/// <summary>
	/// <para>The Item's Auth data was provided via the Automated Micro-deposits flow.</para>
	/// </summary>
	[EnumMember(Value = "AUTOMATED_MICRODEPOSITS")]
	AutomatedMicrodeposits,

	/// <summary>
	/// <para>The Item's Auth data was provided via the Same Day Micro-deposits flow.</para>
	/// </summary>
	[EnumMember(Value = "SAME_DAY_MICRODEPOSITS")]
	SameDayMicrodeposits,

	/// <summary>
	/// <para>The Item's Auth data was provided via the Instant Micro-deposits flow.</para>
	/// </summary>
	[EnumMember(Value = "INSTANT_MICRODEPOSITS")]
	InstantMicrodeposits,

	/// <summary>
	/// <para>The Item's Auth data was provided via the Database Match flow.</para>
	/// </summary>
	[EnumMember(Value = "DATABASE_MATCH")]
	DatabaseMatch,

	/// <summary>
	/// <para>The Item's Auth data was provided via the Database Insights flow.</para>
	/// </summary>
	[EnumMember(Value = "DATABASE_INSIGHTS")]
	DatabaseInsights,

	/// <summary>
	/// <para>The Item's Auth data was provided via <a href="https://plaid.com/docs/api/products/transfer/account-linking/#migrate-account-into-transfers"><c>/transfer/migrate_account</c></a>.</para>
	/// </summary>
	[EnumMember(Value = "TRANSFER_MIGRATED")]
	TransferMigrated,

	/// <summary>
	/// <para>The Item's Auth data for Investments Move was provided via a <a href="https://plaid.com/docs/investments-move/#fallback-flows">fallback flow</a>.</para>
	/// </summary>
	[EnumMember(Value = "INVESTMENTS_FALLBACK")]
	InvestmentsFallback,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

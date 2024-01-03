namespace Going.Plaid.Entity;

/// <summary>
/// <para>The warning code identifies a specific kind of warning.</para>
/// </summary>
public enum CreditBankIncomeWarningCode
{
	/// <summary>
	/// <para>Unable to extract identity for the Item</para>
	/// </summary>
	[EnumMember(Value = "IDENTITY_UNAVAILABLE")]
	IdentityUnavailable,

	/// <summary>
	/// <para>Unable to extract transactions for the Item</para>
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS_UNAVAILABLE")]
	TransactionsUnavailable,

	/// <summary>
	/// <para>User exited flow before giving permission to share data for the Item</para>
	/// </summary>
	[EnumMember(Value = "ITEM_UNAPPROVED")]
	ItemUnapproved,

	/// <summary>
	/// <para>Report deleted due to customer or consumer request</para>
	/// </summary>
	[EnumMember(Value = "REPORT_DELETED")]
	ReportDeleted,

	/// <summary>
	/// <para>No relevant data was found for the Item</para>
	/// </summary>
	[EnumMember(Value = "DATA_UNAVAILABLE")]
	DataUnavailable,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

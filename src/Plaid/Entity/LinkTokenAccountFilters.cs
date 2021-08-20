namespace Going.Plaid.Entity;

/// <summary>
/// <para>By default, Link will provide limited account filtering: it will only display Institutions that are compatible with all products supplied in the <c>products</c> parameter of <c>/link/token/create</c>, and, if <c>auth</c> is specified in the <c>products</c> array, will also filter out accounts other than <c>checking</c> and <c>savings</c> accounts on the Account Select pane. You can further limit the accounts shown in Link by using <c>account_filters</c> to specify the account subtypes to be shown in Link. Only the specified subtypes will be shown. This filtering applies to both the Account Select view (if enabled) and the Institution Select view. Institutions that do not support the selected subtypes will be omitted from Link. To indicate that all subtypes should be shown, use the value <c>"all"</c>. If the <c>account_filters</c> filter is used, any account type for which a filter is not specified will be entirely omitted from Link. For a full list of valid types and subtypes, see the <a href="https://plaid.com/docs/api/accounts#accounts-schema">Account schema</a>.</para>
/// <para>For institutions using OAuth, the filter will not affect the list of accounts shown by the bank in the OAuth window.</para>
/// </summary>
public class LinkTokenAccountFilters
{
	/// <summary>
	/// <para>A filter to apply to <c>depository</c>-type accounts</para>
	/// </summary>
	[JsonPropertyName("depository")]
	public Entity.DepositoryFilter Depository { get; set; } = default!;

	/// <summary>
	/// <para>A filter to apply to <c>credit</c>-type accounts</para>
	/// </summary>
	[JsonPropertyName("credit")]
	public Entity.CreditFilter Credit { get; set; } = default!;

	/// <summary>
	/// <para>A filter to apply to <c>loan</c>-type accounts</para>
	/// </summary>
	[JsonPropertyName("loan")]
	public Entity.LoanFilter Loan { get; set; } = default!;

	/// <summary>
	/// <para>A filter to apply to <c>investment</c>-type accounts</para>
	/// </summary>
	[JsonPropertyName("investment")]
	public Entity.InvestmentFilter Investment { get; set; } = default!;
}
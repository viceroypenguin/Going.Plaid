namespace Going.Plaid.Entity;

/// <summary>
/// <para>A filter to apply to <c>loan</c>-type accounts</para>
/// </summary>
public class LoanFilter
{
	/// <summary>
	/// <para>An array of account subtypes to display in Link. If not specified, all account subtypes will be shown. For a full list of valid types and subtypes, see the <a href="https://plaid.com/docs/api/accounts#accounts-schema">Account schema</a>.</para>
	/// </summary>
	[JsonPropertyName("account_subtypes")]
	public IReadOnlyList<Entity.AccountSubtype> AccountSubtypes { get; set; } = default!;
}
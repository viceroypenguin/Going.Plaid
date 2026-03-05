namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsRulesListRequest defines the request schema for <c>/beta/transactions/rules/v1/list</c></para>
/// </summary>
public partial class TransactionsRulesListRequest : RequestBase
{
	/// <summary>
	/// <para>A unique ID representing the end user whose rules should be listed.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

}

namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsUserInsightsGetRequest defines the request schema for <c>/beta/transactions/user_insights/v1/get</c>.</para>
/// </summary>
public partial class TransactionsUserInsightsGetRequest : RequestBase
{
	/// <summary>
	/// <para>A unique client-provided <c>client_user_id</c> to retrieve insights for.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

}

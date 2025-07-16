namespace Going.Plaid.User;

/// <summary>
/// <para>UserTransactionsRefreshRequest defines the request schema for <c>user/transactions/refresh</c></para>
/// </summary>
public partial class UserTransactionsRefreshRequest : RequestBase
{
	/// <summary>
	/// <para>A Plaid-generated ID that identifies the end user.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

}

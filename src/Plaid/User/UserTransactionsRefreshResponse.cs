namespace Going.Plaid.User;

/// <summary>
/// <para>UserTransactionsRefreshResponse defines the response schema for <c>user/transactions/refresh</c></para>
/// </summary>
public record UserTransactionsRefreshResponse : ResponseBase
{
	/// <summary>
	/// <para>The user ID associated with the refresh request.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("results")]
	public IReadOnlyList<Entity.RefreshResult>? Results { get; init; } = default!;

}

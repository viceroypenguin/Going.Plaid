namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/migrate_account</c></para>
/// </summary>
public record TransferMigrateAccountResponse : ResponseBase
{
	/// <summary>
	/// <para>The Plaid <c>access_token</c> for the newly created Item.</para>
	/// </summary>
	[JsonPropertyName("access_token")]
	public string AccessToken { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid <c>account_id</c> for the newly created Item.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;
}
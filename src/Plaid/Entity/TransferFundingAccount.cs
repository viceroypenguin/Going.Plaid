namespace Going.Plaid.Entity;

/// <summary>
/// <para>The originator's funding account, linked with Plaid Link or <c>/transfer/migrate_account</c>.</para>
/// </summary>
public class TransferFundingAccount
{
	/// <summary>
	/// <para>The access token associated with the Item data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("access_token")]
	public string AccessToken { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid <c>account_id</c> for the newly created Item.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;
}
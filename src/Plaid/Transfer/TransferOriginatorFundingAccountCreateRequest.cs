namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/originator/funding_account/create</c></para>
/// </summary>
public partial class TransferOriginatorFundingAccountCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The Plaid client ID of the transfer originator.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>The originator's funding account, linked with Plaid Link or <c>/transfer/migrate_account</c>.</para>
	/// </summary>
	[JsonPropertyName("funding_account")]
	public Entity.TransferFundingAccount FundingAccount { get; set; } = default!;

}

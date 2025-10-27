namespace Going.Plaid.Beta;

/// <summary>
/// <para>Request schema for <c>/beta/partner/customer/v1/update</c>.</para>
/// </summary>
public partial class BetaPartnerCustomerV1UpdateRequest : RequestBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("end_customer_client_id")]
	public string EndCustomerClientId { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("legal_entity_name")]
	public string? LegalEntityName { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("redirect_uris")]
	public IReadOnlyList<string>? RedirectUris { get; set; } = default!;

	/// <summary>
	/// <para>The bank addendum acceptance for the end customer.</para>
	/// </summary>
	[JsonPropertyName("bank_addendum_acceptance")]
	public Entity.PartnerEndCustomerBankAddendumAcceptance? BankAddendumAcceptance { get; set; } = default!;

	/// <summary>
	/// <para>The questionnaires for the end customer.</para>
	/// </summary>
	[JsonPropertyName("questionnaires")]
	public Entity.PartnerEndCustomerQuestionnaires? Questionnaires { get; set; } = default!;

}

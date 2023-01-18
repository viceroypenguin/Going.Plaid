namespace Going.Plaid.Partner;

/// <summary>
/// <para>Response schema for <c>/partner/customer/oauth_institutions/get</c>.</para>
/// </summary>
public record PartnerCustomerOAuthInstitutionsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The status of the addendum to the Plaid MSA ("flowdown") for the end customer.</para>
	/// </summary>
	[JsonPropertyName("flowdown_status")]
	public Entity.PartnerEndCustomerFlowdownStatus FlowdownStatus { get; init; } = default!;

	/// <summary>
	/// <para>The status of the end customer's security questionnaire.</para>
	/// </summary>
	[JsonPropertyName("questionnaire_status")]
	public Entity.PartnerEndCustomerQuestionnaireStatus QuestionnaireStatus { get; init; } = default!;

	/// <summary>
	/// <para>The OAuth institutions with which the end customer's application is being registered.</para>
	/// </summary>
	[JsonPropertyName("institutions")]
	public IReadOnlyList<Entity.PartnerEndCustomerOAuthInstitution> Institutions { get; init; } = default!;
}
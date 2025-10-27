namespace Going.Plaid.Entity;

/// <summary>
/// <para>The questionnaires for the end customer.</para>
/// </summary>
public class PartnerEndCustomerQuestionnaires
{
	/// <summary>
	/// <para>The CRA questionnaire for the end customer.</para>
	/// </summary>
	[JsonPropertyName("cra")]
	public Entity.PartnerEndCustomerCRAQuestionnaire? Cra { get; set; } = default!;

}

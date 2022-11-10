namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/questionnaire/create</c></para>
/// </summary>
public record TransferQuestionnaireCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Plaid-hosted onboarding URL that you will redirect the end customer to.</para>
	/// </summary>
	[JsonPropertyName("onboarding_url")]
	public string OnboardingUrl { get; init; } = default!;
}
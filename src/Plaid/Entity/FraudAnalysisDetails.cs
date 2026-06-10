namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the fraud analysis performed on the document.</para>
/// </summary>
public record FraudAnalysisDetails
{
	/// <summary>
	/// <para>Whether the submitted document type is supported for fraud analysis.</para>
	/// <para><c>success</c> - The document type is supported.</para>
	/// <para><c>failed</c> - The document type is not supported.</para>
	/// </summary>
	[JsonPropertyName("type_supported")]
	public Entity.FraudCheckOutcome TypeSupported { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the portrait presence check.</para>
	/// <para><c>success</c> - A portrait was detected.</para>
	/// <para><c>failed</c> - No portrait was detected.</para>
	/// </summary>
	[JsonPropertyName("portrait_presence_check")]
	public Entity.FraudCheckOutcome PortraitPresenceCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the portrait details check including photo embedding and face landmark checks.</para>
	/// <para><c>success</c> - The portrait passed all validity checks.</para>
	/// <para><c>failed</c> - The portrait did not pass one or more validity checks.</para>
	/// </summary>
	[JsonPropertyName("portrait_details_check")]
	public Entity.FraudCheckOutcome PortraitDetailsCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the image composition check.</para>
	/// <para><c>success</c> - The image is a valid physical document capture.</para>
	/// <para><c>failed</c> - The image appears to be a photograph of a screen or a digital forgery.</para>
	/// </summary>
	[JsonPropertyName("image_composition_check")]
	public Entity.FraudCheckOutcome ImageCompositionCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the integrity check for document security elements.</para>
	/// <para><c>success</c> - Data is consistent across all checked security elements.</para>
	/// <para><c>failed</c> - Inconsistencies were detected across one or more security elements.</para>
	/// </summary>
	[JsonPropertyName("integrity_check")]
	public Entity.FraudCheckOutcome IntegrityCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the document detail check for correct styling and layout.</para>
	/// <para><c>success</c> - The document passed all authenticity checks.</para>
	/// <para><c>failed</c> - The document did not pass one or more authenticity checks.</para>
	/// </summary>
	[JsonPropertyName("detail_check")]
	public Entity.FraudCheckOutcome DetailCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the issue date validity check.</para>
	/// <para><c>success</c> - The issue date is valid.</para>
	/// <para><c>failed</c> - The issue date is invalid or could not be verified.</para>
	/// <para><c>no_data</c> - The check could not be performed due to insufficient data.</para>
	/// </summary>
	[JsonPropertyName("issue_date_check")]
	public Entity.FraudCheckOutcomeWithNoData IssueDateCheck { get; init; } = default!;

}

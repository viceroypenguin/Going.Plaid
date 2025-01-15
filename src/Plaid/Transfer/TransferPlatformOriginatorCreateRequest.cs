namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/platform/originator/create</c></para>
/// </summary>
public partial class TransferPlatformOriginatorCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The client ID of the originator</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>Metadata related to the acceptance of Terms of Service</para>
	/// </summary>
	[JsonPropertyName("tos_acceptance_metadata")]
	public Entity.TOSAcceptanceMetadata TosAcceptanceMetadata { get; set; } = default!;

	/// <summary>
	/// <para>ISO8601 timestamp indicating the most recent time the platform collected onboarding data from the originator</para>
	/// </summary>
	[JsonPropertyName("originator_reviewed_at")]
	public DateTimeOffset OriginatorReviewedAt { get; set; } = default!;

	/// <summary>
	/// <para>The webhook URL to which a <c>PLATFORM_ONBOARDING_UPDATE</c> webhook should be sent.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>The image or video capture of a selfie. Only one of <c>image_url</c> or <c>video_url</c> will be populated per selfie. In the vast majority of sessions Plaid records a short video of the user, so <c>video_url</c> is populated and <c>image_url</c> is <c>null</c>. <c>image_url</c> is only populated in the rare passive-liveness fallback case, where the user's device could not complete the standard video liveness capture (for example, a camera or streaming error) and submitted a single still image instead.</para>
/// </summary>
public record SelfieCapture
{
	/// <summary>
	/// <para>Temporary URL for downloading a still-image selfie capture. This field is only populated when the session fell back to passive (image-based) liveness. For the majority of selfie checks this field is <c>null</c> and <c>video_url</c> is populated instead.</para>
	/// </summary>
	[JsonPropertyName("image_url")]
	public string? ImageUrl { get; init; } = default!;

	/// <summary>
	/// <para>Temporary URL for downloading a video selfie capture. This is the standard selfie capture for Identity Verification. Plaid records a short video of the user during the Selfie Check liveness step, so this field is populated for the vast majority of selfie checks.</para>
	/// </summary>
	[JsonPropertyName("video_url")]
	public string? VideoUrl { get; init; } = default!;

}

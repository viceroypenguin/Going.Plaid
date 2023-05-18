namespace Going.Plaid.Entity;

/// <summary>
/// <para>The image or video capture of a selfie. Only one of image or video URL will be populated per selfie.</para>
/// </summary>
public record SelfieCapture
{
	/// <summary>
	/// <para>Temporary URL for downloading an image selfie capture.</para>
	/// </summary>
	[JsonPropertyName("image_url")]
	public string? ImageUrl { get; init; } = default!;

	/// <summary>
	/// <para>Temporary URL for downloading a video selfie capture.</para>
	/// </summary>
	[JsonPropertyName("video_url")]
	public string? VideoUrl { get; init; } = default!;
}
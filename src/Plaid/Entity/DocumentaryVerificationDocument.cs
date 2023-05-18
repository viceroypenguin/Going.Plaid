namespace Going.Plaid.Entity;

/// <summary>
/// <para>Images, extracted data, and analysis from a user's identity document</para>
/// </summary>
public record DocumentaryVerificationDocument
{
	/// <summary>
	/// <para>An outcome status for this specific document submission. Distinct from the overall <c>documentary_verification.status</c> that summarizes the verification outcome from one or more documents.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.DocumentStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The <c>attempt</c> field begins with 1 and increments with each subsequent document upload.</para>
	/// </summary>
	[JsonPropertyName("attempt")]
	public int Attempt { get; init; } = default!;

	/// <summary>
	/// <para>URLs for downloading original and cropped images for this document submission. The URLs are designed to only allow downloading, not hot linking, so the URL will only serve the document image for 60 seconds before expiring. The expiration time is 60 seconds after the <c>GET</c> request for the associated Identity Verification attempt. A new expiring URL is generated with each request, so you can always rerequest the Identity Verification attempt if one of your URLs expires.</para>
	/// </summary>
	[JsonPropertyName("images")]
	public Entity.PhysicalDocumentImages Images { get; init; } = default!;

	/// <summary>
	/// <para>Data extracted from a user-submitted document.</para>
	/// </summary>
	[JsonPropertyName("extracted_data")]
	public Entity.PhysicalDocumentExtractedData? ExtractedData { get; init; } = default!;

	/// <summary>
	/// <para>High level descriptions of how the associated document was processed. If a document fails verification, the details in the <c>analysis</c> object should help clarify why the document was rejected.</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.DocumentAnalysis Analysis { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("redacted_at")]
	public DateTimeOffset? RedactedAt { get; init; } = default!;
}
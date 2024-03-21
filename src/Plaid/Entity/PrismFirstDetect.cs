namespace Going.Plaid.Entity;

/// <summary>
/// <para>The data from the Firstdetect product returned by Prism.</para>
/// </summary>
public record PrismFirstDetect
{
	/// <summary>
	/// <para>The version of Prism's Firstdetect model used.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public int Version { get; init; } = default!;

	/// <summary>
	/// <para>The score returned by Prism. Ranges from 1-999, with higher score indicating lower risk.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;

	/// <summary>
	/// <para>The reasons for an individual having risk according to the Firstdetect score.</para>
	/// </summary>
	[JsonPropertyName("reason_codes")]
	public IReadOnlyList<string>? ReasonCodes { get; init; } = default!;

	/// <summary>
	/// <para>An object containing metadata about the provided transactions.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.PrismCashScoreMetadata? Metadata { get; init; } = default!;

}

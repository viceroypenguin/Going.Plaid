namespace Going.Plaid.Entity;

/// <summary>
/// <para>The data from the Detect product returned by Prism.</para>
/// </summary>
public record PrismDetect
{
	/// <summary>
	/// <para>The version of Prism's detect model used.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public int Version { get; init; } = default!;

	/// <summary>
	/// <para>The score returned by Prism. Ranges from 1-999, with higher score indicating lower risk.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;

	/// <summary>
	/// <para>The reasons for an individual having risk according to the detect cash score.</para>
	/// </summary>
	[JsonPropertyName("reason_codes")]
	public IReadOnlyList<string>? ReasonCodes { get; init; } = default!;

	/// <summary>
	/// <para>An object containing metadata about the provided transactions.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.PrismCashScoreMetadata? Metadata { get; init; } = default!;

}

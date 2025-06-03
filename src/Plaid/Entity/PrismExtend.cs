namespace Going.Plaid.Entity;

/// <summary>
/// <para>The data from the CashScore® Extend product returned by Prism Data.</para>
/// </summary>
public record PrismExtend
{
	/// <summary>
	/// <para>The version of Prism Data's CashScore® Extend model used.</para>
	/// </summary>
	[JsonPropertyName("model_version")]
	public string ModelVersion { get; init; } = default!;

	/// <summary>
	/// <para>The score returned by Prism Data. Ranges from 1-999, with higher score indicating lower risk.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

	/// <summary>
	/// <para>The reasons for an individual having risk according to the CashScore® Extend score.</para>
	/// </summary>
	[JsonPropertyName("reason_codes")]
	public IReadOnlyList<string>? ReasonCodes { get; init; } = default!;

	/// <summary>
	/// <para>An object containing metadata about the provided transactions.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.PrismCashScoreMetadata? Metadata { get; init; } = default!;

	/// <summary>
	/// <para>The error returned by Prism for this product.</para>
	/// </summary>
	[JsonPropertyName("error_reason")]
	public string? ErrorReason { get; init; } = default!;

}

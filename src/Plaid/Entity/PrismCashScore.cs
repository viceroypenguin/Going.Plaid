namespace Going.Plaid.Entity;

/// <summary>
/// <para>The data from the CashScore® product returned by Prism Data.</para>
/// </summary>
public record PrismCashScore
{
	/// <summary>
	/// <para>The version of Prism Data's cash score model used. This field is deprecated in favor of <c>model_version</c>.</para>
	/// </summary>
	[JsonPropertyName("version")]
	[Obsolete]
	public int Version { get; init; } = default!;

	/// <summary>
	/// <para>The version of Prism Data's cash score model used.</para>
	/// </summary>
	[JsonPropertyName("model_version")]
	public string? ModelVersion { get; init; } = default!;

	/// <summary>
	/// <para>The score returned by Prism Data. Ranges from 1-999, with higher score indicating lower risk.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

	/// <summary>
	/// <para>The reasons for an individual having risk according to the cash score.</para>
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

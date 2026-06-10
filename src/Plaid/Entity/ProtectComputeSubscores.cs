namespace Going.Plaid.Entity;

/// <summary>
/// <para>Per-bucket subscores returned alongside the overall Trust Index score. For cash-advance models, each key maps to an amount-bucket subscore (0-100); higher values indicate lower fraud risk. Only buckets that were scored are included in the response.</para>
/// </summary>
public record ProtectComputeSubscores
{
	/// <summary>
	/// <para>Subscore for cash advance amounts in the range $0-$25.</para>
	/// </summary>
	[JsonPropertyName("cash_advance_bucket_0_25")]
	public int? CashAdvanceBucket025 { get; init; } = default!;

	/// <summary>
	/// <para>Subscore for cash advance amounts in the range $25-$50.</para>
	/// </summary>
	[JsonPropertyName("cash_advance_bucket_25_50")]
	public int? CashAdvanceBucket2550 { get; init; } = default!;

	/// <summary>
	/// <para>Subscore for cash advance amounts in the range $50-$100.</para>
	/// </summary>
	[JsonPropertyName("cash_advance_bucket_50_100")]
	public int? CashAdvanceBucket50100 { get; init; } = default!;

	/// <summary>
	/// <para>Subscore for cash advance amounts in the range $100-$200.</para>
	/// </summary>
	[JsonPropertyName("cash_advance_bucket_100_200")]
	public int? CashAdvanceBucket100200 { get; init; } = default!;

	/// <summary>
	/// <para>Subscore for cash advance amounts in the range $200-$300.</para>
	/// </summary>
	[JsonPropertyName("cash_advance_bucket_200_300")]
	public int? CashAdvanceBucket200300 { get; init; } = default!;

	/// <summary>
	/// <para>Subscore for cash advance amounts in the range $300-$400.</para>
	/// </summary>
	[JsonPropertyName("cash_advance_bucket_300_400")]
	public int? CashAdvanceBucket300400 { get; init; } = default!;

	/// <summary>
	/// <para>Subscore for cash advance amounts in the range $400-$500.</para>
	/// </summary>
	[JsonPropertyName("cash_advance_bucket_400_500")]
	public int? CashAdvanceBucket400500 { get; init; } = default!;

}

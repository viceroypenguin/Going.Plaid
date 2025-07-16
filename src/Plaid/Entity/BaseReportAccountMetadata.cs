namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata about the extracted account.</para>
/// </summary>
public record BaseReportAccountMetadata
{
	/// <summary>
	/// <para>The beginning of the range of the financial institution provided data for the account, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ("yyyy-mm-dd").</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The end of the range of the financial institution provided data for the account, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ("yyyy-mm-dd").</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

}

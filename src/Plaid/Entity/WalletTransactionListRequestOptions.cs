namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional wallet transaction options</para>
/// </summary>
public class WalletTransactionListRequestOptions
{
	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DDThh:mm:ssZ) for filtering transactions, inclusive of the provided date.</para>
	/// </summary>
	[JsonPropertyName("start_time")]
	public DateTimeOffset StartTime { get; set; } = default!;

	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DDThh:mm:ssZ) for filtering transactions, inclusive of the provided date.</para>
	/// </summary>
	[JsonPropertyName("end_time")]
	public DateTimeOffset EndTime { get; set; } = default!;
}
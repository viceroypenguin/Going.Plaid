namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public record TaxpayerID
{
	/// <summary>
	/// <para>Type of ID, e.g. 'SSN'</para>
	/// </summary>
	[JsonPropertyName("id_type")]
	public string? IdType { get; init; } = default!;

	/// <summary>
	/// <para>Last 4 digits of unique number of ID.</para>
	/// </summary>
	[JsonPropertyName("last_4_digits")]
	public string? Last4Digits { get; init; } = default!;
}
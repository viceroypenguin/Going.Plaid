namespace Going.Plaid.Entity;

/// <summary>
/// <para>Taxpayer ID of the individual receiving the paystub.</para>
/// </summary>
public record TaxpayerID
{
	/// <summary>
	/// <para>Type of ID, e.g. 'SSN'</para>
	/// </summary>
	[JsonPropertyName("id_type")]
	public string? IdType { get; init; } = default!;

	/// <summary>
	/// <para>ID mask; i.e. last 4 digits of the taxpayer ID</para>
	/// </summary>
	[JsonPropertyName("id_mask")]
	public string? IdMask { get; init; } = default!;

	/// <summary>
	/// <para>Last 4 digits of unique number of ID.</para>
	/// </summary>
	[JsonPropertyName("last_4_digits")]
	[Obsolete]
	public string? Last4Digits { get; init; } = default!;

}

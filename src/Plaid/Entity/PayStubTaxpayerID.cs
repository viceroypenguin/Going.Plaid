namespace Going.Plaid.Entity;

/// <summary>
/// <para>Taxpayer ID of the individual receiving the paystub.</para>
/// </summary>
public record PayStubTaxpayerID
{
	/// <summary>
	/// <para>Type of ID, e.g. 'SSN'.</para>
	/// </summary>
	[JsonPropertyName("id_type")]
	public string? IdType { get; init; } = default!;

	/// <summary>
	/// <para>ID mask; i.e. last 4 digits of the taxpayer ID.</para>
	/// </summary>
	[JsonPropertyName("id_mask")]
	public string? IdMask { get; init; } = default!;

}

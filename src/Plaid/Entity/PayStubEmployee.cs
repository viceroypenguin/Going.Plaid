namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data about the employee.</para>
/// </summary>
public record PayStubEmployee
{
	/// <summary>
	/// <para>Address on the pay stub.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.PayStubAddress Address { get; init; } = default!;

	/// <summary>
	/// <para>The name of the employee.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>Marital status of the employee - either <c>SINGLE</c> or <c>MARRIED</c>.</para>
	/// </summary>
	[JsonPropertyName("marital_status")]
	public string? MaritalStatus { get; init; } = default!;

	/// <summary>
	/// <para>Taxpayer ID of the individual receiving the paystub.</para>
	/// </summary>
	[JsonPropertyName("taxpayer_id")]
	public Entity.PayStubTaxpayerID TaxpayerId { get; init; } = default!;
}
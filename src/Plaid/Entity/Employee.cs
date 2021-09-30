namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data about the employee.</para>
/// </summary>
public record Employee
{
	/// <summary>
	/// <para>The name of the employee.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.Address Address { get; init; } = default!;

	/// <summary>
	/// <para>Marital status of the employee.</para>
	/// </summary>
	[JsonPropertyName("marital_status")]
	public string? MaritalStatus { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("taxpayer_id")]
	public Entity.TaxpayerID TaxpayerId { get; init; } = default!;
}
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
	public Entity.AddressData? Address { get; init; } = default!;
}
namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a filer used by 1099-K tax documents.</para>
/// </summary>
public record Credit1099Filer
{
	/// <summary>
	/// <para>Address on the pay stub.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.CreditPayStubAddress Address { get; init; } = default!;

	/// <summary>
	/// <para>Name of filer.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>Tax identification number of filer.</para>
	/// </summary>
	[JsonPropertyName("tin")]
	public string? Tin { get; init; } = default!;

	/// <summary>
	/// <para>One of the following values will be provided: Payment Settlement Entity (PSE), Electronic Payment Fecilitator (EPF), Other Third Party</para>
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; init; } = default!;
}
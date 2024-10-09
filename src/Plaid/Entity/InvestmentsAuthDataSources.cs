namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object with metadata pertaining to the source of data for the account numbers, owners, and holdings that are returned.</para>
/// </summary>
public record InvestmentsAuthDataSources
{
	/// <summary>
	/// <para>A description of the source of data for a given product/data type.</para>
	/// </summary>
	[JsonPropertyName("numbers")]
	public Entity.DataSources? Numbers { get; init; } = default!;

	/// <summary>
	/// <para>A description of the source of data for a given product/data type.</para>
	/// </summary>
	[JsonPropertyName("owners")]
	public Entity.DataSources? Owners { get; init; } = default!;

	/// <summary>
	/// <para>A description of the source of data for a given product/data type.</para>
	/// </summary>
	[JsonPropertyName("holdings")]
	public Entity.DataSources? Holdings { get; init; } = default!;

}

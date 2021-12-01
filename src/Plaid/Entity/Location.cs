namespace Going.Plaid.Entity;

/// <summary>
/// <para>A representation of where a transaction took place</para>
/// </summary>
public record Location
{
	/// <summary>
	/// <para>The street address where the transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public string? Address { get; init; } = default!;

	/// <summary>
	/// <para>The city where the transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; init; } = default!;

	/// <summary>
	/// <para>The region or state where the transaction occurred. In API versions 2018-05-22 and earlier, this field is called <c>state</c>.</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string? Region { get; init; } = default!;

	/// <summary>
	/// <para>The postal code where the transaction occurred. In API versions 2018-05-22 and earlier, this field is called <c>zip</c>.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string? PostalCode { get; init; } = default!;

	/// <summary>
	/// <para>The ISO 3166-1 alpha-2 country code where the transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; init; } = default!;

	/// <summary>
	/// <para>The latitude where the transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("lat")]
	public decimal? Lat { get; init; } = default!;

	/// <summary>
	/// <para>The longitude where the transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("lon")]
	public decimal? Lon { get; init; } = default!;

	/// <summary>
	/// <para>The merchant defined store number where the transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("store_number")]
	public string? StoreNumber { get; init; } = default!;
}
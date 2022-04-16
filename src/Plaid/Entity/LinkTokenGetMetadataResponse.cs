namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object specifying the arguments originally provided to the <c>/link/token/create</c> call.</para>
/// </summary>
public record LinkTokenGetMetadataResponse : ResponseBase
{
	/// <summary>
	/// <para>The <c>products</c> specified in the <c>/link/token/create</c> call.</para>
	/// </summary>
	[JsonPropertyName("initial_products")]
	public IReadOnlyList<Entity.Products> InitialProducts { get; init; } = default!;

	/// <summary>
	/// <para>The <c>webhook</c> specified in the <c>/link/token/create</c> call.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; init; } = default!;

	/// <summary>
	/// <para>The <c>country_codes</c> specified in the <c>/link/token/create</c> call.</para>
	/// </summary>
	[JsonPropertyName("country_codes")]
	public IReadOnlyList<Entity.CountryCode> CountryCodes { get; init; } = default!;

	/// <summary>
	/// <para>The <c>language</c> specified in the <c>/link/token/create</c> call.</para>
	/// </summary>
	[JsonPropertyName("language")]
	public string? Language { get; init; } = default!;

	/// <summary>
	/// <para>A map containing data used to highlight institutions in Link.</para>
	/// </summary>
	[JsonPropertyName("institution_data")]
	public Entity.LinkTokenCreateInstitutionData InstitutionData { get; init; } = default!;

	/// <summary>
	/// <para>The <c>account_filters</c> specified in the original call to <c>/link/token/create</c>.</para>
	/// </summary>
	[JsonPropertyName("account_filters")]
	public Entity.AccountFiltersResponse AccountFilters { get; init; } = default!;

	/// <summary>
	/// <para>The <c>redirect_uri</c> specified in the <c>/link/token/create</c> call.</para>
	/// </summary>
	[JsonPropertyName("redirect_uri")]
	public string? RedirectUri { get; init; } = default!;

	/// <summary>
	/// <para>The <c>client_name</c> specified in the <c>/link/token/create</c> call.</para>
	/// </summary>
	[JsonPropertyName("client_name")]
	public string? ClientName { get; init; } = default!;
}
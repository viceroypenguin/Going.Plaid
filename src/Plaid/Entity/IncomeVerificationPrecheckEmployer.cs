namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the end user's employer</para>
/// </summary>
public class IncomeVerificationPrecheckEmployer
{
	/// <summary>
	/// <para>The employer's name</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; set; } = default!;

	/// <summary>
	/// <para>The address of the employer</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.IncomeVerificationPrecheckEmployerAddress? Address { get; set; } = default!;

	/// <summary>
	/// <para>The employer's tax id</para>
	/// </summary>
	[JsonPropertyName("tax_id")]
	public string? TaxId { get; set; } = default!;

	/// <summary>
	/// <para>The URL for the employer's public website</para>
	/// </summary>
	[JsonPropertyName("url")]
	public string? Url { get; set; } = default!;

}

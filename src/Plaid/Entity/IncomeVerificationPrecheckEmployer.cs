namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public class IncomeVerificationPrecheckEmployer
{
	/// <summary>
	/// <para>The employer's name</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; set; } = default!;

	/// <summary>
	/// <para>The employer's tax id</para>
	/// </summary>
	[JsonPropertyName("tax_id")]
	public string? TaxId { get; set; } = default!;
}
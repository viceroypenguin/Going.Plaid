namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public record W2StateAndLocalWages
{
	/// <summary>
	/// <para>State associated with the wage.</para>
	/// </summary>
	[JsonPropertyName("state")]
	public string? State { get; init; } = default!;

	/// <summary>
	/// <para>State identification number of the employer.</para>
	/// </summary>
	[JsonPropertyName("employer_state_id_number")]
	public string? EmployerStateIdNumber { get; init; } = default!;

	/// <summary>
	/// <para>Wages and tips from the specified state.</para>
	/// </summary>
	[JsonPropertyName("state_wages_tips")]
	public string? StateWagesTips { get; init; } = default!;

	/// <summary>
	/// <para>Income tax from the specified state.</para>
	/// </summary>
	[JsonPropertyName("state_income_tax")]
	public string? StateIncomeTax { get; init; } = default!;

	/// <summary>
	/// <para>Wages and tips from the locality.</para>
	/// </summary>
	[JsonPropertyName("local_wages_tips")]
	public string? LocalWagesTips { get; init; } = default!;

	/// <summary>
	/// <para>Income tax from the locality.</para>
	/// </summary>
	[JsonPropertyName("local_income_tax")]
	public string? LocalIncomeTax { get; init; } = default!;

	/// <summary>
	/// <para>Name of the locality.</para>
	/// </summary>
	[JsonPropertyName("locality_name")]
	public string? LocalityName { get; init; } = default!;
}
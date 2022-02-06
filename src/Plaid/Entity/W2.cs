namespace Going.Plaid.Entity;

/// <summary>
/// <para>W2 is an object that represents income data taken from a W2 tax document.</para>
/// </summary>
public record W2
{
	/// <summary>
	/// <para>Information about the employer on the paystub</para>
	/// </summary>
	[JsonPropertyName("employer")]
	public Entity.Employer Employer { get; init; } = default!;

	/// <summary>
	/// <para>Data about the employee.</para>
	/// </summary>
	[JsonPropertyName("employee")]
	public Entity.Employee Employee { get; init; } = default!;

	/// <summary>
	/// <para>The tax year of the W2 document.</para>
	/// </summary>
	[JsonPropertyName("tax_year")]
	public string? TaxYear { get; init; } = default!;

	/// <summary>
	/// <para>An employee identification number or EIN.</para>
	/// </summary>
	[JsonPropertyName("employer_id_number")]
	public string? EmployerIdNumber { get; init; } = default!;

	/// <summary>
	/// <para>Wages from tips and other compensation.</para>
	/// </summary>
	[JsonPropertyName("wages_tips_other_comp")]
	public string? WagesTipsOtherComp { get; init; } = default!;

	/// <summary>
	/// <para>Federal income tax withheld for the tax year.</para>
	/// </summary>
	[JsonPropertyName("federal_income_tax_withheld")]
	public string? FederalIncomeTaxWithheld { get; init; } = default!;

	/// <summary>
	/// <para>Wages from social security.</para>
	/// </summary>
	[JsonPropertyName("social_security_wages")]
	public string? SocialSecurityWages { get; init; } = default!;

	/// <summary>
	/// <para>Social security tax withheld for the tax year.</para>
	/// </summary>
	[JsonPropertyName("social_security_tax_withheld")]
	public string? SocialSecurityTaxWithheld { get; init; } = default!;

	/// <summary>
	/// <para>Wages and tips from medicare.</para>
	/// </summary>
	[JsonPropertyName("medicare_wages_and_tips")]
	public string? MedicareWagesAndTips { get; init; } = default!;

	/// <summary>
	/// <para>Medicare tax withheld for the tax year.</para>
	/// </summary>
	[JsonPropertyName("medicare_tax_withheld")]
	public string? MedicareTaxWithheld { get; init; } = default!;

	/// <summary>
	/// <para>Tips from social security.</para>
	/// </summary>
	[JsonPropertyName("social_security_tips")]
	public string? SocialSecurityTips { get; init; } = default!;

	/// <summary>
	/// <para>Allocated tips.</para>
	/// </summary>
	[JsonPropertyName("allocated_tips")]
	public string? AllocatedTips { get; init; } = default!;

	/// <summary>
	/// <para>Contents from box 9 on the W2.</para>
	/// </summary>
	[JsonPropertyName("box_9")]
	public string? Box9 { get; init; } = default!;

	/// <summary>
	/// <para>Dependent care benefits.</para>
	/// </summary>
	[JsonPropertyName("dependent_care_benefits")]
	public string? DependentCareBenefits { get; init; } = default!;

	/// <summary>
	/// <para>Nonqualified plans.</para>
	/// </summary>
	[JsonPropertyName("nonqualified_plans")]
	public string? NonqualifiedPlans { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("box_12")]
	public IReadOnlyList<Entity.W2Box12> Box12 { get; init; } = default!;

	/// <summary>
	/// <para>Statutory employee.</para>
	/// </summary>
	[JsonPropertyName("statutory_employee")]
	public string? StatutoryEmployee { get; init; } = default!;

	/// <summary>
	/// <para>Retirement plan.</para>
	/// </summary>
	[JsonPropertyName("retirement_plan")]
	public string? RetirementPlan { get; init; } = default!;

	/// <summary>
	/// <para>Third party sick pay.</para>
	/// </summary>
	[JsonPropertyName("third_party_sick_pay")]
	public string? ThirdPartySickPay { get; init; } = default!;

	/// <summary>
	/// <para>Other.</para>
	/// </summary>
	[JsonPropertyName("other")]
	public string? Other { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("state_and_local_wages")]
	public IReadOnlyList<Entity.W2StateAndLocalWages> StateAndLocalWages { get; init; } = default!;
}
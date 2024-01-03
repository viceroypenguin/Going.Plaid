namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an end user's 1099 tax form</para>
/// </summary>
public record Credit1099
{
	/// <summary>
	/// <para>An identifier of the document referenced by the document metadata.</para>
	/// </summary>
	[JsonPropertyName("document_id")]
	public string? DocumentId { get; init; } = default!;

	/// <summary>
	/// <para>Object representing metadata pertaining to the document.</para>
	/// </summary>
	[JsonPropertyName("document_metadata")]
	public Entity.CreditDocumentMetadata? DocumentMetadata { get; init; } = default!;

	/// <summary>
	/// <para>Form 1099 Type</para>
	/// </summary>
	[JsonPropertyName("form_1099_type")]
	public Entity.Form1099Type? Form1099Type { get; init; } = default!;

	/// <summary>
	/// <para>An object representing a recipient used in both 1099-K and 1099-MISC tax documents.</para>
	/// </summary>
	[JsonPropertyName("recipient")]
	public Entity.Credit1099Recipient? Recipient { get; init; } = default!;

	/// <summary>
	/// <para>An object representing a payer used by 1099-MISC tax documents.</para>
	/// </summary>
	[JsonPropertyName("payer")]
	public Entity.Credit1099Payer? Payer { get; init; } = default!;

	/// <summary>
	/// <para>An object representing a filer used by 1099-K tax documents.</para>
	/// </summary>
	[JsonPropertyName("filer")]
	public Entity.Credit1099Filer? Filer { get; init; } = default!;

	/// <summary>
	/// <para>Tax year of the tax form.</para>
	/// </summary>
	[JsonPropertyName("tax_year")]
	public string? TaxYear { get; init; } = default!;

	/// <summary>
	/// <para>Amount in rent by payer.</para>
	/// </summary>
	[JsonPropertyName("rents")]
	public decimal? Rents { get; init; } = default!;

	/// <summary>
	/// <para>Amount in royalties by payer.</para>
	/// </summary>
	[JsonPropertyName("royalties")]
	public decimal? Royalties { get; init; } = default!;

	/// <summary>
	/// <para>Amount in other income by payer.</para>
	/// </summary>
	[JsonPropertyName("other_income")]
	public decimal? OtherIncome { get; init; } = default!;

	/// <summary>
	/// <para>Amount of federal income tax withheld from payer.</para>
	/// </summary>
	[JsonPropertyName("federal_income_tax_withheld")]
	public decimal? FederalIncomeTaxWithheld { get; init; } = default!;

	/// <summary>
	/// <para>Amount of fishing boat proceeds from payer.</para>
	/// </summary>
	[JsonPropertyName("fishing_boat_proceeds")]
	public decimal? FishingBoatProceeds { get; init; } = default!;

	/// <summary>
	/// <para>Amount of medical and healthcare payments from payer.</para>
	/// </summary>
	[JsonPropertyName("medical_and_healthcare_payments")]
	public decimal? MedicalAndHealthcarePayments { get; init; } = default!;

	/// <summary>
	/// <para>Amount of nonemployee compensation from payer.</para>
	/// </summary>
	[JsonPropertyName("nonemployee_compensation")]
	public decimal? NonemployeeCompensation { get; init; } = default!;

	/// <summary>
	/// <para>Amount of substitute payments made by payer.</para>
	/// </summary>
	[JsonPropertyName("substitute_payments_in_lieu_of_dividends_or_interest")]
	public decimal? SubstitutePaymentsInLieuOfDividendsOrInterest { get; init; } = default!;

	/// <summary>
	/// <para>Whether or not payer made direct sales over $5000 of consumer products.</para>
	/// </summary>
	[JsonPropertyName("payer_made_direct_sales_of_5000_or_more_of_consumer_products_to_buyer")]
	public string? PayerMadeDirectSalesOf5000OrMoreOfConsumerProductsToBuyer { get; init; } = default!;

	/// <summary>
	/// <para>Amount of crop insurance proceeds.</para>
	/// </summary>
	[JsonPropertyName("crop_insurance_proceeds")]
	public decimal? CropInsuranceProceeds { get; init; } = default!;

	/// <summary>
	/// <para>Amount of golden parachute payments made by payer.</para>
	/// </summary>
	[JsonPropertyName("excess_golden_parachute_payments")]
	public decimal? ExcessGoldenParachutePayments { get; init; } = default!;

	/// <summary>
	/// <para>Amount of gross proceeds paid to an attorney by payer.</para>
	/// </summary>
	[JsonPropertyName("gross_proceeds_paid_to_an_attorney")]
	public decimal? GrossProceedsPaidToAnAttorney { get; init; } = default!;

	/// <summary>
	/// <para>Amount of 409A deferrals earned by payer.</para>
	/// </summary>
	[JsonPropertyName("section_409a_deferrals")]
	public decimal? Section409aDeferrals { get; init; } = default!;

	/// <summary>
	/// <para>Amount of 409A income earned by payer.</para>
	/// </summary>
	[JsonPropertyName("section_409a_income")]
	public decimal? Section409aIncome { get; init; } = default!;

	/// <summary>
	/// <para>Amount of state tax withheld of payer for primary state.</para>
	/// </summary>
	[JsonPropertyName("state_tax_withheld")]
	public decimal? StateTaxWithheld { get; init; } = default!;

	/// <summary>
	/// <para>Amount of state tax withheld of payer for secondary state.</para>
	/// </summary>
	[JsonPropertyName("state_tax_withheld_lower")]
	public decimal? StateTaxWithheldLower { get; init; } = default!;

	/// <summary>
	/// <para>Primary state ID.</para>
	/// </summary>
	[JsonPropertyName("payer_state_number")]
	public string? PayerStateNumber { get; init; } = default!;

	/// <summary>
	/// <para>Secondary state ID.</para>
	/// </summary>
	[JsonPropertyName("payer_state_number_lower")]
	public string? PayerStateNumberLower { get; init; } = default!;

	/// <summary>
	/// <para>State income reported for primary state.</para>
	/// </summary>
	[JsonPropertyName("state_income")]
	public decimal? StateIncome { get; init; } = default!;

	/// <summary>
	/// <para>State income reported for secondary state.</para>
	/// </summary>
	[JsonPropertyName("state_income_lower")]
	public decimal? StateIncomeLower { get; init; } = default!;

	/// <summary>
	/// <para>One of the values will be provided Payment card Third party network</para>
	/// </summary>
	[JsonPropertyName("transactions_reported")]
	public string? TransactionsReported { get; init; } = default!;

	/// <summary>
	/// <para>Name of the PSE (Payment Settlement Entity).</para>
	/// </summary>
	[JsonPropertyName("pse_name")]
	public string? PseName { get; init; } = default!;

	/// <summary>
	/// <para>Formatted (XXX) XXX-XXXX. Phone number of the PSE (Payment Settlement Entity).</para>
	/// </summary>
	[JsonPropertyName("pse_telephone_number")]
	public string? PseTelephoneNumber { get; init; } = default!;

	/// <summary>
	/// <para>Gross amount reported.</para>
	/// </summary>
	[JsonPropertyName("gross_amount")]
	public decimal? GrossAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount in card not present transactions.</para>
	/// </summary>
	[JsonPropertyName("card_not_present_transaction")]
	public decimal? CardNotPresentTransaction { get; init; } = default!;

	/// <summary>
	/// <para>Merchant category of filer.</para>
	/// </summary>
	[JsonPropertyName("merchant_category_code")]
	public string? MerchantCategoryCode { get; init; } = default!;

	/// <summary>
	/// <para>Number of payment transactions made.</para>
	/// </summary>
	[JsonPropertyName("number_of_payment_transactions")]
	public string? NumberOfPaymentTransactions { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for January.</para>
	/// </summary>
	[JsonPropertyName("january_amount")]
	public decimal? JanuaryAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for February.</para>
	/// </summary>
	[JsonPropertyName("february_amount")]
	public decimal? FebruaryAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for March.</para>
	/// </summary>
	[JsonPropertyName("march_amount")]
	public decimal? MarchAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for April.</para>
	/// </summary>
	[JsonPropertyName("april_amount")]
	public decimal? AprilAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for May.</para>
	/// </summary>
	[JsonPropertyName("may_amount")]
	public decimal? MayAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for June.</para>
	/// </summary>
	[JsonPropertyName("june_amount")]
	public decimal? JuneAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for July.</para>
	/// </summary>
	[JsonPropertyName("july_amount")]
	public decimal? JulyAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for August.</para>
	/// </summary>
	[JsonPropertyName("august_amount")]
	public decimal? AugustAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for September.</para>
	/// </summary>
	[JsonPropertyName("september_amount")]
	public decimal? SeptemberAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for October.</para>
	/// </summary>
	[JsonPropertyName("october_amount")]
	public decimal? OctoberAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for November.</para>
	/// </summary>
	[JsonPropertyName("november_amount")]
	public decimal? NovemberAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount reported for December.</para>
	/// </summary>
	[JsonPropertyName("december_amount")]
	public decimal? DecemberAmount { get; init; } = default!;

	/// <summary>
	/// <para>Primary state of business.</para>
	/// </summary>
	[JsonPropertyName("primary_state")]
	public string? PrimaryState { get; init; } = default!;

	/// <summary>
	/// <para>Secondary state of business.</para>
	/// </summary>
	[JsonPropertyName("secondary_state")]
	public string? SecondaryState { get; init; } = default!;

	/// <summary>
	/// <para>Primary state ID.</para>
	/// </summary>
	[JsonPropertyName("primary_state_id")]
	public string? PrimaryStateId { get; init; } = default!;

	/// <summary>
	/// <para>Secondary state ID.</para>
	/// </summary>
	[JsonPropertyName("secondary_state_id")]
	public string? SecondaryStateId { get; init; } = default!;

	/// <summary>
	/// <para>State income tax reported for primary state.</para>
	/// </summary>
	[JsonPropertyName("primary_state_income_tax")]
	public decimal? PrimaryStateIncomeTax { get; init; } = default!;

	/// <summary>
	/// <para>State income tax reported for secondary state.</para>
	/// </summary>
	[JsonPropertyName("secondary_state_income_tax")]
	public decimal? SecondaryStateIncomeTax { get; init; } = default!;

}

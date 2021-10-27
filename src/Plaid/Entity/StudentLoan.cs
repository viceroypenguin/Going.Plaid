namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains details about a student loan account</para>
/// </summary>
public record StudentLoan
{
	/// <summary>
	/// <para>The ID of the account that this liability belongs to.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The account number of the loan. For some institutions, this may be a masked version of the number (e.g., the last 4 digits instead of the entire number).</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string? AccountNumber { get; init; } = default!;

	/// <summary>
	/// <para>The dates on which loaned funds were disbursed or will be disbursed. These are often in the past. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("disbursement_dates")]
	public IReadOnlyList<DateOnly>? DisbursementDates { get; init; } = default!;

	/// <summary>
	/// <para>The date when the student loan is expected to be paid off. Availability for this field is limited. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("expected_payoff_date")]
	public DateOnly? ExpectedPayoffDate { get; init; } = default!;

	/// <summary>
	/// <para>The guarantor of the student loan.</para>
	/// </summary>
	[JsonPropertyName("guarantor")]
	public string? Guarantor { get; init; } = default!;

	/// <summary>
	/// <para>The interest rate on the loan as a percentage.</para>
	/// </summary>
	[JsonPropertyName("interest_rate_percentage")]
	public decimal InterestRatePercentage { get; init; } = default!;

	/// <summary>
	/// <para><c>true</c> if a payment is currently overdue. Availability for this field is limited.</para>
	/// </summary>
	[JsonPropertyName("is_overdue")]
	public bool? IsOverdue { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the last payment.</para>
	/// </summary>
	[JsonPropertyName("last_payment_amount")]
	public decimal? LastPaymentAmount { get; init; } = default!;

	/// <summary>
	/// <para>The date of the last payment. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("last_payment_date")]
	public DateOnly? LastPaymentDate { get; init; } = default!;

	/// <summary>
	/// <para>The date of the last statement. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("last_statement_issue_date")]
	public DateOnly? LastStatementIssueDate { get; init; } = default!;

	/// <summary>
	/// <para>The type of loan, e.g., "Consolidation Loans".</para>
	/// </summary>
	[JsonPropertyName("loan_name")]
	public string? LoanName { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the status of the student loan</para>
	/// </summary>
	[JsonPropertyName("loan_status")]
	public Entity.StudentLoanStatus LoanStatus { get; init; } = default!;

	/// <summary>
	/// <para>The minimum payment due for the next billing cycle. There are some exceptions:</para>
	/// <para>Some institutions require a minimum payment across all loans associated with an account number. Our API presents that same minimum payment amount on each loan. The institutions that do this are: Great Lakes ( <c>ins_116861</c>), Firstmark (<c>ins_116295</c>), Commonbond Firstmark Services (<c>ins_116950</c>), Nelnet (<c>ins_116528</c>), EdFinancial Services (<c>ins_116304</c>), Granite State (<c>ins_116308</c>), and Oklahoma Student Loan Authority (<c>ins_116945</c>).</para>
	/// <para>Firstmark (<c>ins_116295</c> ) will display as $0 if there is an autopay program in effect.</para>
	/// </summary>
	[JsonPropertyName("minimum_payment_amount")]
	public decimal? MinimumPaymentAmount { get; init; } = default!;

	/// <summary>
	/// <para>The due date for the next payment. The due date is <c>null</c> if a payment is not expected. A payment is not expected if <c>loan_status.type</c> is <c>deferment</c>, <c>in_school</c>, <c>consolidated</c>, <c>paid in full</c>, or <c>transferred</c>. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("next_payment_due_date")]
	public DateOnly? NextPaymentDueDate { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the loan was initially lent. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("origination_date")]
	public DateOnly? OriginationDate { get; init; } = default!;

	/// <summary>
	/// <para>The original principal balance of the loan.</para>
	/// </summary>
	[JsonPropertyName("origination_principal_amount")]
	public decimal? OriginationPrincipalAmount { get; init; } = default!;

	/// <summary>
	/// <para>The total dollar amount of the accrued interest balance. For Sallie Mae ( <c>ins_116944</c>), this amount is included in the current balance of the loan, so this field will return as <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("outstanding_interest_amount")]
	public decimal? OutstandingInterestAmount { get; init; } = default!;

	/// <summary>
	/// <para>The relevant account number that should be used to reference this loan for payments. In the majority of cases, <c>payment_reference_number</c> will match a<c>ccount_number,</c> but in some institutions, such as Great Lakes (<c>ins_116861</c>), it will be different.</para>
	/// </summary>
	[JsonPropertyName("payment_reference_number")]
	public string? PaymentReferenceNumber { get; init; } = default!;

	/// <summary>
	/// <para>Information about the student's eligibility in the Public Service Loan Forgiveness program. This is only returned if the institution is Fedloan (<c>ins_116527</c>).</para>
	/// </summary>
	[JsonPropertyName("pslf_status")]
	public Entity.PSLFStatus PslfStatus { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the repayment plan for the student loan</para>
	/// </summary>
	[JsonPropertyName("repayment_plan")]
	public Entity.StudentRepaymentPlan RepaymentPlan { get; init; } = default!;

	/// <summary>
	/// <para>The sequence number of the student loan. Heartland ECSI (<c>ins_116948</c>) does not make this field available.</para>
	/// </summary>
	[JsonPropertyName("sequence_number")]
	public string? SequenceNumber { get; init; } = default!;

	/// <summary>
	/// <para>The address of the student loan servicer. This is generally the remittance address to which payments should be sent.</para>
	/// </summary>
	[JsonPropertyName("servicer_address")]
	public Entity.ServicerAddressData ServicerAddress { get; init; } = default!;

	/// <summary>
	/// <para>The year to date (YTD) interest paid. Availability for this field is limited.</para>
	/// </summary>
	[JsonPropertyName("ytd_interest_paid")]
	public decimal? YtdInterestPaid { get; init; } = default!;

	/// <summary>
	/// <para>The year to date (YTD) principal paid. Availability for this field is limited.</para>
	/// </summary>
	[JsonPropertyName("ytd_principal_paid")]
	public decimal? YtdPrincipalPaid { get; init; } = default!;
}
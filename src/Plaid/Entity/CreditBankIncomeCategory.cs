namespace Going.Plaid.Entity;

/// <summary>
/// <para>The income category.</para>
/// </summary>
public enum CreditBankIncomeCategory
{
	/// <summary>
	/// <para>Payment from an employer to an earner or other form of permanent employment.</para>
	/// </summary>
	[EnumMember(Value = "SALARY")]
	Salary,

	/// <summary>
	/// <para>Unemployment benefits. In the UK, includes certain low-income benefits such as the Universal Credit.</para>
	/// </summary>
	[EnumMember(Value = "UNEMPLOYMENT")]
	Unemployment,

	/// <summary>
	/// <para>Deprecated and used only for existing legacy implementations. Has been replaced by <c>CASH_DEPOSIT</c> and <c>TRANSFER_FROM_APPLICATION</c>.</para>
	/// </summary>
	[EnumMember(Value = "CASH")]
	Cash,

	/// <summary>
	/// <para>Income earned as a gig economy worker, e.g. driving for Uber, Lyft, Postmates, DoorDash, etc.</para>
	/// </summary>
	[EnumMember(Value = "GIG_ECONOMY")]
	GigEconomy,

	/// <summary>
	/// <para>Income earned from a rental property. Income may be identified as rental when the payment is received through a rental platform, e.g. Airbnb; rent paid directly by the tenant to the property owner (e.g. via cash, check, or ACH) will typically not be classified as rental income.</para>
	/// </summary>
	[EnumMember(Value = "RENTAL")]
	Rental,

	/// <summary>
	/// <para>Child support payments received.</para>
	/// </summary>
	[EnumMember(Value = "CHILD_SUPPORT")]
	ChildSupport,

	/// <summary>
	/// <para>Veterans benefits. Income earned as salary for serving in the military (e.g. through DFAS) will be classified as <c>SALARY</c> rather than <c>MILITARY</c>.</para>
	/// </summary>
	[EnumMember(Value = "MILITARY")]
	Military,

	/// <summary>
	/// <para>Payments from private retirement systems, pensions, and government retirement programs, including Social Security retirement benefits.</para>
	/// </summary>
	[EnumMember(Value = "RETIREMENT")]
	Retirement,

	/// <summary>
	/// <para>Disability payments, including Social Security disability benefits.</para>
	/// </summary>
	[EnumMember(Value = "LONG_TERM_DISABILITY")]
	LongTermDisability,

	/// <summary>
	/// <para>Interest earned from a bank account.</para>
	/// </summary>
	[EnumMember(Value = "BANK_INTEREST")]
	BankInterest,

	/// <summary>
	/// <para>A cash or check deposit.</para>
	/// </summary>
	[EnumMember(Value = "CASH_DEPOSIT")]
	CashDeposit,

	/// <summary>
	/// <para>Deposits from a money transfer app, such as Venmo, Cash App, or Zelle.</para>
	/// </summary>
	[EnumMember(Value = "TRANSFER_FROM_APPLICATION")]
	TransferFromApplication,

	/// <summary>
	/// <para>A tax refund.</para>
	/// </summary>
	[EnumMember(Value = "TAX_REFUND")]
	TaxRefund,

	/// <summary>
	/// <para>Government benefits other than retirement, unemployment, child support, or disability. Currently used only in the UK, to represent benefits such as Cost of Living Payments.</para>
	/// </summary>
	[EnumMember(Value = "BENEFIT_OTHER")]
	BenefitOther,

	/// <summary>
	/// <para>Income that could not be categorized as any other income category.</para>
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

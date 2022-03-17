namespace Going.Plaid.Entity;

/// <summary>
/// <para>Flow types to retrieve payroll income data</para>
/// </summary>
public enum IncomeVerificationPayrollFlowType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "payroll_digital_income")]
	PayrollDigitalIncome,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "payroll_document_income")]
	PayrollDocumentIncome,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
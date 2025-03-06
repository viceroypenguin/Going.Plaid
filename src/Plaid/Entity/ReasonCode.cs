namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies the reason for cancelling transfer. This is required for RfP transfers, and will be ignored for other networks.</para>
/// </summary>
public enum ReasonCode
{
	/// <summary>
	/// <para>Invalid Creditor Account Number</para>
	/// </summary>
	[EnumMember(Value = "AC03")]
	Ac03,

	/// <summary>
	/// <para>Incorrect Amount</para>
	/// </summary>
	[EnumMember(Value = "AM09")]
	Am09,

	/// <summary>
	/// <para>Requested By Customer - Cancellation requested</para>
	/// </summary>
	[EnumMember(Value = "CUST")]
	Cust,

	/// <summary>
	/// <para>Duplicate Payment</para>
	/// </summary>
	[EnumMember(Value = "DUPL")]
	Dupl,

	/// <summary>
	/// <para>Fraudulent Payment - Unauthorized or fraudulently induced</para>
	/// </summary>
	[EnumMember(Value = "FRAD")]
	Frad,

	/// <summary>
	/// <para>Technical Problem - Cancellation due to system issues</para>
	/// </summary>
	[EnumMember(Value = "TECH")]
	Tech,

	/// <summary>
	/// <para>Undue Payment - Payment was made through another channel</para>
	/// </summary>
	[EnumMember(Value = "UPAY")]
	Upay,

	/// <summary>
	/// <para>Invalid or Missing Creditor Account Type</para>
	/// </summary>
	[EnumMember(Value = "AC14")]
	Ac14,

	/// <summary>
	/// <para>Amount Too Low</para>
	/// </summary>
	[EnumMember(Value = "AM06")]
	Am06,

	/// <summary>
	/// <para>Unrecognized Initiating Party</para>
	/// </summary>
	[EnumMember(Value = "BE05")]
	Be05,

	/// <summary>
	/// <para>Following Refund Request</para>
	/// </summary>
	[EnumMember(Value = "FOCR")]
	Focr,

	/// <summary>
	/// <para>No Specified Reason - Customer</para>
	/// </summary>
	[EnumMember(Value = "MS02")]
	Ms02,

	/// <summary>
	/// <para>No Specified Reason - Agent</para>
	/// </summary>
	[EnumMember(Value = "MS03")]
	Ms03,

	/// <summary>
	/// <para>Regulatory Reason</para>
	/// </summary>
	[EnumMember(Value = "RR04")]
	Rr04,

	/// <summary>
	/// <para>Return Upon Unable To Apply</para>
	/// </summary>
	[EnumMember(Value = "RUTA")]
	Ruta,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

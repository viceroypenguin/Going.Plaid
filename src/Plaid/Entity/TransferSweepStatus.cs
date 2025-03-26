namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the sweep for the transfer.</para>
/// </summary>
public enum TransferSweepStatus
{
	/// <summary>
	/// <para>The transfer hasn't been swept yet.</para>
	/// </summary>
	[EnumMember(Value = "unswept")]
	Unswept,

	/// <summary>
	/// <para>The transfer was swept to the sweep account.</para>
	/// </summary>
	[EnumMember(Value = "swept")]
	Swept,

	/// <summary>
	/// <para>Credits are available to be withdrawn or debits have been deducted from the customer’s business checking account.</para>
	/// </summary>
	[EnumMember(Value = "swept_settled")]
	SweptSettled,

	/// <summary>
	/// <para>The transfer was returned, funds were pulled back or pushed back to the sweep account.</para>
	/// </summary>
	[EnumMember(Value = "return_swept")]
	ReturnSwept,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

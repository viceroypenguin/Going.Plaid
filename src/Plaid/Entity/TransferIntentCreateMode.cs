namespace Going.Plaid.Entity;

/// <summary>
/// <para>The direction of the flow of transfer funds.</para>
/// </summary>
public enum TransferIntentCreateMode
{
	/// <summary>
	/// <para>Transfers funds from an end user's account to your business account.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT")]
	Payment,

	/// <summary>
	/// <para>Transfers funds from your business account to an end user's account.</para>
	/// </summary>
	[EnumMember(Value = "DISBURSEMENT")]
	Disbursement,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
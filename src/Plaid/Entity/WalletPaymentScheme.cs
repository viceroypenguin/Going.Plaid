namespace Going.Plaid.Entity;

/// <summary>
/// <para>The payment scheme used to execute this transaction. This is present only for transaction types <c>PAYOUT</c> and <c>REFUND</c>.</para>
/// </summary>
public enum WalletPaymentScheme
{
	/// <summary>
	/// <para>The standard payment scheme within the UK.</para>
	/// </summary>
	[EnumMember(Value = "FASTER_PAYMENTS")]
	FasterPayments,

	/// <summary>
	/// <para>The standard payment to a beneficiary within the SEPA area.</para>
	/// </summary>
	[EnumMember(Value = "SEPA_CREDIT_TRANSFER")]
	SepaCreditTransfer,

	/// <summary>
	/// <para>Instant payment to a beneficiary within the SEPA area.</para>
	/// </summary>
	[EnumMember(Value = "SEPA_CREDIT_TRANSFER_INSTANT")]
	SepaCreditTransferInstant,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

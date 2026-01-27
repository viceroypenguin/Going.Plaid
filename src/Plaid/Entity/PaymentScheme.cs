namespace Going.Plaid.Entity;

/// <summary>
/// <para>Payment scheme. If not specified - the default in the region will be used (e.g. <c>SEPA_CREDIT_TRANSFER</c> for EU). In responses, if the scheme is not explicitly specified in the request, this value will be <c>null</c>. Using unsupported values will result in a failed payment.</para>
/// </summary>
public enum PaymentScheme
{
	/// <summary>
	/// <para>The default payment scheme for the selected market and currency will be used.</para>
	/// </summary>
	[EnumMember(Value = "LOCAL_DEFAULT")]
	LocalDefault,

	/// <summary>
	/// <para>The instant payment scheme for the selected market and currency will be used (if applicable). Fees may be applied by the institution.</para>
	/// </summary>
	[EnumMember(Value = "LOCAL_INSTANT")]
	LocalInstant,

	/// <summary>
	/// <para>The standard payment to a beneficiary within the SEPA area.</para>
	/// </summary>
	[EnumMember(Value = "SEPA_CREDIT_TRANSFER")]
	SepaCreditTransfer,

	/// <summary>
	/// <para>Instant payment within the SEPA area. May involve additional fees and may not be available at some banks.</para>
	/// </summary>
	[EnumMember(Value = "SEPA_CREDIT_TRANSFER_INSTANT")]
	SepaCreditTransferInstant,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}

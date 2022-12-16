namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of the transaction. The supported transaction types that are returned are:</para>
/// </summary>
public enum WalletTransactionTypeEnum
{
	/// <summary>
	/// <para>a transaction which credits an e-wallet through an external bank transfer.</para>
	/// </summary>
	[EnumMember(Value = "BANK_TRANSFER")]
	BankTransfer,

	/// <summary>
	/// <para>a transaction which debits an e-wallet by disbursing funds to a counterparty.</para>
	/// </summary>
	[EnumMember(Value = "PAYOUT")]
	Payout,

	/// <summary>
	/// <para>a payment which credits an e-wallet through Plaid's Payment Initiation Services (PIS) APIs. For more information see the <a href="https://plaid.com/docs/api/products/payment-initiation/">Payment Initiation endpoints</a>.</para>
	/// </summary>
	[EnumMember(Value = "PIS_PAY_IN")]
	PisPayIn,

	/// <summary>
	/// <para>a transaction which debits an e-wallet by refunding a previously initiated payment made through Plaid's <a href="https://plaid.com/docs/api/products/payment-initiation/">PIS APIs</a>.</para>
	/// </summary>
	[EnumMember(Value = "REFUND")]
	Refund,

	/// <summary>
	/// <para>an automated transaction which debits funds from an e-wallet to a designated client-owned account.</para>
	/// </summary>
	[EnumMember(Value = "FUNDS_SWEEP")]
	FundsSweep,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
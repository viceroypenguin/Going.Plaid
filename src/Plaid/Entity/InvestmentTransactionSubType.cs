using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Acklann.Plaid.Entity
{
	public enum InvestmentTransactionSubType
	{
		/// <summary>
		/// Fees paid for account maintenance.
		/// </summary>
		[EnumMember(Value = "account fee")]
		AccountFee,

		/// <summary>
		/// Assignment of short option holding.
		/// </summary>
		[EnumMember(Value = "assignment")]
		Assignment,

		/// <summary>
		/// Purchase to open or increase a position.
		/// </summary>
		[EnumMember(Value = "buy")]
		Buy,

		/// <summary>
		/// Purchase to close a short position.
		/// </summary>
		[EnumMember(Value = "buy to cover")]
		BuyToCover,

		/// <summary>
		/// Inflow of assets into a tax-advantaged account.
		/// </summary>
		[EnumMember(Value = "contribution")]
		Contribution,

		/// <summary>
		/// Inflow of cash into an account.
		/// </summary>
		[EnumMember(Value = "deposit")]
		Deposit,

		/// <summary>
		/// Outflow of assets from a tax-advantaged account.
		/// </summary>
		[EnumMember(Value = "distribution")]
		Distribution,

		/// <summary>
		/// Inflow of cash from a dividend.
		/// </summary>
		[EnumMember(Value = "dividend")]
		Dividend,

		/// <summary>
		/// Purchase using proceeds from a cash dividend.
		/// </summary>
		[EnumMember(Value = "dividend reinvestment")]
		DividendReinvestment,

		/// <summary>
		/// Exercise of an option or warrant contract.
		/// </summary>
		[EnumMember(Value = "exercise")]
		Exercise,

		/// <summary>
		/// Expiration of an option or warrant contract.
		/// </summary>
		[EnumMember(Value = "expire")]
		Expire,

		/// <summary>
		/// Fees paid for administration of a mutual fund or other pooled investment vehicle.
		/// </summary>
		[EnumMember(Value = "fund fee")]
		FundFee,

		/// <summary>
		/// Inflow of cash from interest.
		/// </summary>
		[EnumMember(Value = "interest")]
		Interest,

		/// <summary>
		/// Inflow of cash from interest receivable.
		/// </summary>
		[EnumMember(Value = "interest receivable")]
		InterestReceivable,

		/// <summary>
		/// Purchase using proceeds from a cash interest payment.
		/// </summary>
		[EnumMember(Value = "interest reinvestment")]
		InterestReinvestment,

		/// <summary>
		/// Fees paid for legal charges or services.
		/// </summary>
		[EnumMember(Value = "legal fee")]
		LegalFee,

		/// <summary>
		/// Inflow of cash related to payment on a loan.
		/// </summary>
		[EnumMember(Value = "loan payment")]
		LoanPayment,

		/// <summary>
		/// Long-term capital gain received as cash.
		/// </summary>
		[EnumMember(Value = "long-term capital gain")]
		LongTermCapitalGain,

		/// <summary>
		/// Purchase using long-term capital gain cash proceeds.
		/// </summary>
		[EnumMember(Value = "long-term capital gain reinvestment")]
		LongTermCapitalGainReinvestment,

		/// <summary>
		/// Fees paid for investment management of a mutual fund or other pooled investment vehicle.
		/// </summary>
		[EnumMember(Value = "management fee")]
		ManagementFee,

		/// <summary>
		/// Fees paid for maintaining margin debt.
		/// </summary>
		[EnumMember(Value = "margin expense")]
		MarginExpense,

		/// <summary>
		/// Stock exchanged at a pre-defined ratio as part of a merger between companies.
		/// </summary>
		[EnumMember(Value = "merger")]
		Merger,

		/// <summary>
		/// Fees associated with various account or holding actions.
		/// </summary>
		[EnumMember(Value = "miscellaneous fee")]
		MiscellaneousFee,

		/// <summary>
		/// Inflow of cash from a non-qualified dividend.
		/// </summary>
		[EnumMember(Value = "non-qualified dividend")]
		NonQualifiedDividend,

		/// <summary>
		/// Taxes paid on behalf of the investor for non-residency in investment jurisdiction.
		/// </summary>
		[EnumMember(Value = "non-resident tax")]
		NonResidentTax,

		/// <summary>
		/// Pending inflow of cash.
		/// </summary>
		[EnumMember(Value = "pending credit")]
		PendingCredit,

		/// <summary>
		/// Pending outflow of cash.
		/// </summary>
		[EnumMember(Value = "pending debit")]
		PendingDebit,

		/// <summary>
		/// Inflow of cash from a qualified dividend.
		/// </summary>
		[EnumMember(Value = "qualified dividend")]
		QualifiedDividend,

		/// <summary>
		/// Rebalancing transaction (buy or sell) with no net impact to value in the account.
		/// </summary>
		[EnumMember(Value = "rebalance")]
		Rebalance,

		/// <summary>
		/// Repayment of loan principal.
		/// </summary>
		[EnumMember(Value = "return of principal")]
		ReturnOfPrincipal,

		/// <summary>
		/// Sell to close or decrease an existing holding.
		/// </summary>
		[EnumMember(Value = "sell")]
		Sell,

		/// <summary>
		/// Sell to open a short position.
		/// </summary>
		[EnumMember(Value = "sell short")]
		SellShort,

		/// <summary>
		/// Short-term capital gain received as cash.
		/// </summary>
		[EnumMember(Value = "short-term capital gain")]
		ShortTermCapitalGain,

		/// <summary>
		/// Purchase using short-term capital gain cash proceeds.
		/// </summary>
		[EnumMember(Value = "short-term capital gain reinvestment")]
		ShortTermCapitalGainReinvestment,

		/// <summary>
		/// Inflow of stock from spin-off transaction of an existing holding.
		/// </summary>
		[EnumMember(Value = "spin off")]
		SpinOff,

		/// <summary>
		/// Inflow of stock from a forward split of an existing holding.
		/// </summary>
		[EnumMember(Value = "split")]
		Split,

		/// <summary>
		/// Inflow of stock from a distribution.
		/// </summary>
		[EnumMember(Value = "stock distribution")]
		StockDistribution,

		/// <summary>
		/// Taxes paid on behalf of the investor.
		/// </summary>
		[EnumMember(Value = "tax")]
		Tax,

		/// <summary>
		/// Taxes withheld on behalf of the customer.
		/// </summary>
		[EnumMember(Value = "tax withheld")]
		TaxWithheld,

		/// <summary>
		/// Movement of assets into or out of an account.
		/// </summary>
		[EnumMember(Value = "transfer")]
		Transfer,

		/// <summary>
		/// Fees incurred for transfer of a holding or account.
		/// </summary>
		[EnumMember(Value = "transfer fee")]
		TransferFee,

		/// <summary>
		/// Fees related to adminstration of a trust account.
		/// </summary>
		[EnumMember(Value = "trust fee")]
		TrustFee,

		/// <summary>
		/// Unqualified capital gain received as cash.
		/// </summary>
		[EnumMember(Value = "unqualified gain")]
		UnqualifiedGain,

		/// <summary>
		/// Outflow of cash from an account.
		/// </summary>
		[EnumMember(Value = "withdrawal")]
		Withdrawal,
	}
}

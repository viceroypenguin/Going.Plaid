using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Acklann.Plaid.Entity
{
    public enum SecurityType
    {
        /// <summary>
        /// Cash, currency, and money market funds.
        /// </summary>
        [EnumMember(Value = "cash")]
        Cash,

        /// <summary>
        /// Options, warrants, and other derivative instruments.
        /// </summary>
        [EnumMember(Value = "derivative")]
        Derivative,

        /// <summary>
        /// Domestic and foreign equities.
        /// </summary>
        [EnumMember(Value = "equity")]
        Equity,

        /// <summary>
        /// Multi-asset investment funds traded on exchanges.
        /// </summary>
        [EnumMember(Value = "etf")]
        Etf,

        /// <summary>
        /// Bonds and CDs.
        /// </summary>
        [EnumMember(Value = "fixed income")]
        FixedIncome,

        /// <summary>
        /// Loans and loan receivables.
        /// </summary>
        [EnumMember(Value = "loan")]
        Loan,

        /// <summary>
        /// Open- and closed-end vehicles pooling funds of multiple investors.
        /// </summary>
        [EnumMember(Value = "mutual fund")]
        MutualFund,

        /// <summary>
        /// Any unknown or unclassified investment vehicle.
        /// </summary>
        [EnumMember(Value = "other")]
        Other,
    }
}

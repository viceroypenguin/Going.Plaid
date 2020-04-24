using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Acklann.Plaid.Entity
{
    public enum InvestmentTransactionType
    {
        /// <summary>
        /// Activity that increases the quantity of a holding.
        /// </summary>
        [EnumMember(Value = "buy")]
        Buy,

        /// <summary>
        /// Transaction cancels a previous transaction.
        /// </summary>
        [EnumMember(Value = "cancel")]
        Cancel,

        /// <summary>
        /// Activity which modifies the cash position.
        /// </summary>
        [EnumMember(Value = "cash")]
        Cash,

        /// <summary>
        /// Fees on the account, e.g. commission, bookkeeping, options-related.
        /// </summary>
        [EnumMember(Value = "fee")]
        Fee,

        /// <summary>
        /// Activity that decreases the quantity of a holding.
        /// </summary>
        [EnumMember(Value = "sell")]
        Sell,

        /// <summary>
        /// Activity which modifies a position, not through buy/sell activity e.g. options exercise, portfolio transfer
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer,
    }
}

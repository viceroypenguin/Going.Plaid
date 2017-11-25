using Newtonsoft.Json;
using System;

namespace Acklann.Plaid.Transactions
{
    /// <summary>
    /// Represents a request for plaid's '/transactions/get' endpoint. The '/transactions/get' endpoint allows developers to receive user-authorized transaction data for credit and depository-type Accounts. Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.
    /// </summary>
    /// <remarks>Due to the potentially large number of transactions associated with an <see cref="Entity.Item"/>, results are paginated. Manipulate the count and offset parameters in conjunction with the total_transactions response body field to fetch all available Transactions.</remarks>
    public class GetTransactionsRequest : RequestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionsRequest"/> class.
        /// </summary>
        public GetTransactionsRequest()
        {
            EndDate = DateTime.Now;
            StartDate = DateTime.Now.Subtract(TimeSpan.FromDays(30));
        }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>The start date.</value>
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>The end date.</value>
        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the pagination options.
        /// </summary>
        /// <value>The pagination options.</value>
        [JsonProperty("options")]
        public PaginationOptions Options { get; set; }

        /// <summary>
        /// Represents pagination options.
        /// </summary>
        public class PaginationOptions
        {
            /// <summary>
            /// Gets or sets the number of transactions to fetch, where 0 &lt; count &lt;= 500.
            /// </summary>
            /// <value>The number of transactions to return.</value>
            [JsonProperty("count")]
            public uint Total
            {
                get { return _count; }
                set
                {
                    if (value < 1) _count = 1;
                    else if (value > 500) _count = 500;
                    else _count = value;
                }
            }

            /// <summary>
            /// Gets or sets the number of transactions to skip, where offset &gt;= 0.
            /// </summary>
            /// <value>The offset.</value>
            [JsonProperty("offset")]
            public uint Offset { get; set; }

            /// <summary>
            /// Gets or sets the list of account ids to retrieve for the <see cref="Entity.Item" />. Note: An error will be returned if a provided account_id is not associated with the <see cref="Entity.Item" />.
            /// </summary>
            /// <value>The account ids.</value>
            [JsonProperty("account_ids")]
            public string[] AccountIds { get; set; }

            #region Private Members

            private uint _count = 100;

            #endregion Private Members
        }
    }
}
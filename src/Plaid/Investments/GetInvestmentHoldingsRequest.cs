using Newtonsoft.Json;
using System;

namespace Going.Plaid.Investments
{
    /// <summary>
    /// Represents a request for plaid's '/investments/holdings/get' endpoint. The '/investments/holdings/get' endpoint allows developers to receive user-authorized stock position data for investment-type Accounts. Holding data is standardized across financial institutions, and Holdings are linked to Securities.
    /// 
    /// Every /investments/holdings/get response will contain a list of Securities, providing definitions for all security_id references in the response.
    /// </summary>
    public class GetInvestmentHoldingsRequest : RequestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvestmentHoldingsRequest"/> class.
        /// </summary>
        public GetInvestmentHoldingsRequest() { }

        /// <summary>
        /// Gets or sets the holdings options.
        /// </summary>
        /// <value>The holdings options.</value>
        [JsonProperty("options")]
        public HoldingsOptions Options { get; set; }

        /// <summary>
        /// Represents holdings options.
        /// </summary>
        public class HoldingsOptions
        {
            /// <summary>
            /// Gets or sets the list of account ids to retrieve for the <see cref="Entity.Item" />. Note: An error will be returned if a provided account_id is not associated with the <see cref="Entity.Item" />.
            /// </summary>
            /// <value>The ac count ids.</value>
            [JsonProperty("account_ids")]
            public string[] AccountIds { get; set; }
        }
    }
}
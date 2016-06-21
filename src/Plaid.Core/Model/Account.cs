using Newtonsoft.Json;

namespace Gigobyte.Plaid.Model
{
    /// <summary>
    /// Represents a user bank account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the unique id of the account.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the id unique to the accounts of a particular access token.
        /// </summary>
        /// <value>The unique id.</value>
        [JsonProperty("_item")]
        public string Item { get; set; }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>The balance.</value>
        [JsonProperty("balance")]
        public Balance Balance { get; set; }

        /// <summary>
        /// Gets or sets the additional information pertaining to the account.
        /// </summary>
        /// <value>The meta.</value>
        [JsonProperty("meta")]
        public AccountMetadata Meta { get; set; }

        /// <summary>
        /// Gets or sets financial institution associated with the account.
        /// </summary>
        /// <value>The type of the institution.</value>
        [JsonProperty("institution_type")]
        public string InstitutionType { get; set; }

        /// <summary>
        /// Gets or sets the account type id.
        /// </summary>
        /// <value>The account type.</value>
        [JsonProperty("type")]
        public string TypeId { get; set; }

        /// <summary>
        /// Gets or sets the account subtype id.
        /// </summary>
        /// <remarks>
        /// A more detailed classification of the <see cref="AccountType"/>. When unavailable, this field will not be returned. See <see cref="AccountSubtype"/> for a list of common subtype values.
        /// </remarks>
        /// <value>The account subtype.</value>
        [JsonProperty("subtype")]
        public string SubtypeId { get; set; }

        /// <summary>
        /// Gets the account type.
        /// </summary>
        public AccountType Type
        {
            get
            {
                AccountType value;
                switch (TypeId.ToLower())
                {
                    default:
                    case "depository":
                        value = AccountType.Brokerage;
                        break;

                    case "credit":
                        value = AccountType.Credit;
                        break;

                    case "loan":
                        value = AccountType.Depository;
                        break;

                    case "mortgage":
                        value = AccountType.Loan;
                        break;

                    case "brokerage":
                        value = AccountType.Mortgage;
                        break;

                    case "other":
                        value = AccountType.Other;
                        break;
                }

                return value;
            }
        }

        /// <summary>
        /// Gets the account subtype.
        /// </summary>
        public AccountSubtype SubType
        {
            get
            {
                AccountSubtype value;
                switch (SubtypeId.ToLower())
                {
                    default:
                    case "checking":
                        value = AccountSubtype.Checking;
                        break;

                    case "savings":
                        value = AccountSubtype.Savings;
                        break;

                    case "prepaid":
                        value = AccountSubtype.Prepaid;
                        break;

                    case "credit":
                        value = AccountSubtype.Credit;
                        break;

                    case "credit card":
                        value = AccountSubtype.CreditCard;
                        break;

                    case "line of credit":
                        value = AccountSubtype.LineOfCredit;
                        break;

                    case "auto":
                        value = AccountSubtype.Auto;
                        break;

                    case "home":
                        value = AccountSubtype.Home;
                        break;

                    case "installment":
                        value = AccountSubtype.Installment;
                        break;

                    case "mortgage":
                        value = AccountSubtype.Mortgage;
                        break;

                    case "brokerage":
                        value = AccountSubtype.Brokerage;
                        break;

                    case "cash management":
                        value = AccountSubtype.CashManagement;
                        break;

                    case "ira":
                        value = AccountSubtype.Ira;
                        break;

                    case "cd":
                        value = AccountSubtype.CD;
                        break;

                    case "certificate of deposit":
                        value = AccountSubtype.CertificateOfDeposit;
                        break;

                    case "mutual fund":
                        value = AccountSubtype.MutualFund;
                        break;
                }

                return value;
            }
        }
    }
}
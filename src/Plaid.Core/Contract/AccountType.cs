namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// An <see cref="Account"/> type.
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// Not available
        /// </summary>
        None,

        /// <summary>
        /// Checking or savings account
        /// </summary>
        Depository,

        /// <summary>
        /// Credit card
        /// </summary>
        Credit,

        /// <summary>
        /// Loan account
        /// </summary>
        Loan,

        /// <summary>
        /// Mortgage account
        /// </summary>
        Mortgage,

        /// <summary>
        /// Brokerage account
        /// </summary>
        Brokerage,

        /// <summary>
        /// Non-specified account type
        /// </summary>
        Other
    }
}
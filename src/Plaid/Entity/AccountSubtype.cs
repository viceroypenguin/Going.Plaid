namespace Acklann.Plaid.Entity
{
    /// <summary>
    /// Enum Account Subtype
    /// </summary>
    public enum AccountSubtype
    {
        /// <summary>
        /// 401k, brokerage, ira, retirement, roth, ugma.
        /// </summary>
        Brokerage,

        /// <summary>
        /// credit card, paypal, line of credit, rewards.
        /// </summary>
        Credit,

        /// <summary>
        /// checking, savings, money market, paypal, prepaid.
        /// </summary>
        Depository,

        /// <summary>
        /// auto, commercial, construction, consumer, home, home equity, loan, mortgage, overdraft, line of credit, student.
        /// </summary>
        Loan,

        /// <summary>
        /// The home
        /// </summary>
        Mortgage,

        /// <summary>
        /// 403B, cash management, cd, hsa, keogh, money market, mutual fund, prepaid, recurring, rewards, safe deposit, sarsep, other.
        /// </summary>
        Other
    }
}
namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Provides extension methods for the <see cref="Contract"/> namespace.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Converts a string to an <see cref="AuthenticationMethod"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><see cref="AuthenticationMethod"/>.</returns>
        public static AuthenticationMethod ConvertToMfaType(this string value)
        {
            switch ((value ?? string.Empty).ToLower())
            {
                case "questions":
                    return AuthenticationMethod.SecurityQuestions;

                case "list":
                    return AuthenticationMethod.SendCode;

                default:
                    return AuthenticationMethod.None;
            }
        }

        /// <summary>
        /// Converts a string to an <see cref="AccountType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><see cref="AccountType"/>.</returns>
        public static AccountType ConvertToAccountType(this string value)
        {
            AccountType type;
            switch (value.ToLower())
            {
                default:
                    type = AccountType.None;
                    break;

                case "depository":
                    type = AccountType.Brokerage;
                    break;

                case "credit":
                    type = AccountType.Credit;
                    break;

                case "loan":
                    type = AccountType.Depository;
                    break;

                case "mortgage":
                    type = AccountType.Loan;
                    break;

                case "brokerage":
                    type = AccountType.Mortgage;
                    break;

                case "other":
                    type = AccountType.Other;
                    break;
            }

            return type;
        }

        /// <summary>
        /// Converts a string to an <see cref="AccountSubtype"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><see cref="AccountSubtype"/>.</returns>
        public static AccountSubtype ConvertToAccountSubtype(this string value)
        {
            AccountSubtype type;
            switch (value.ToLower())
            {
                default:
                    type = AccountSubtype.None;
                    break;

                case "checking":
                    type = AccountSubtype.Checking;
                    break;

                case "savings":
                    type = AccountSubtype.Savings;
                    break;

                case "prepaid":
                    type = AccountSubtype.Prepaid;
                    break;

                case "credit":
                    type = AccountSubtype.Credit;
                    break;

                case "credit card":
                    type = AccountSubtype.CreditCard;
                    break;

                case "line of credit":
                    type = AccountSubtype.LineOfCredit;
                    break;

                case "auto":
                    type = AccountSubtype.Auto;
                    break;

                case "home":
                    type = AccountSubtype.Home;
                    break;

                case "installment":
                    type = AccountSubtype.Installment;
                    break;

                case "mortgage":
                    type = AccountSubtype.Mortgage;
                    break;

                case "brokerage":
                    type = AccountSubtype.Brokerage;
                    break;

                case "cash management":
                    type = AccountSubtype.CashManagement;
                    break;

                case "ira":
                    type = AccountSubtype.Ira;
                    break;

                case "cd":
                    type = AccountSubtype.CD;
                    break;

                case "certificate of deposit":
                    type = AccountSubtype.CertificateOfDeposit;
                    break;

                case "mutual fund":
                    type = AccountSubtype.MutualFund;
                    break;
            }

            return type;
        }
    }
}
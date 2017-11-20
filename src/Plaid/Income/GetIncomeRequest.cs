namespace Acklann.Plaid.Income
{
    /// <summary>
    /// Represents a request for plaid's '/income/get' endpoint. The Income endpoint allows you to retrieve information pertaining to a Item’s income. In addition to the annual income, detailed information will be provided for each contributing income stream (or job). Details on each of these fields can be found below.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.RequestBase" />
    public class GetIncomeRequest : RequestBase { }
}
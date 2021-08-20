namespace Going.Plaid.Entity;

/// <summary>
/// <para>The schedule that the payment will be executed on. If a schedule is provided, the payment is automatically set up as a standing order. If no schedule is specified, the payment will be executed only once.</para>
/// </summary>
public class ExternalPaymentScheduleRequest : Entity.ExternalPaymentScheduleBase
{
}
namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object used to restrict the accounts used for payments. If provided, the end user will be able to send payments only from the specified bank account.</para>
/// </summary>
public class PaymentInitiationOptionalRestrictionBacs : Entity.RecipientBACS
{
}
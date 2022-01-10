namespace Going.Plaid.Entity;

/// <summary>
/// <para>A sweep returned from the <c>/sandbox/transfer/sweep/simulate</c> endpoint.</para>
/// <para>Can be null if there are no transfers to include in a sweep.</para>
/// </summary>
public record SimulatedTransferSweep : Entity.TransferSweep
{
}
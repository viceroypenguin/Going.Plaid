namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraLoansUnregisterRequest defines the request schema for <c>/cra/loans/unregister</c></para>
/// </summary>
public partial class CraLoansUnregisterRequest : RequestBase
{
	/// <summary>
	/// <para>A list of loans to unregister.</para>
	/// </summary>
	[JsonPropertyName("loans")]
	public IReadOnlyList<Entity.CraLoanUnregister> Loans { get; set; } = default!;

}

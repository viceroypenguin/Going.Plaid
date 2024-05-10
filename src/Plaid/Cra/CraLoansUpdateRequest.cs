namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraLoansUpdateRequest defines the request schema for <c>/cra/loans/update</c></para>
/// </summary>
public partial class CraLoansUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>A list of loans to update.</para>
	/// </summary>
	[JsonPropertyName("loans")]
	public IReadOnlyList<Entity.CraLoanUpdate> Loans { get; set; } = default!;

}

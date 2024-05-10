namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraLoansRegisterRequest defines the request schema for <c>/cra/loans/register</c></para>
/// </summary>
public partial class CRALoansRegisterRequest : RequestBase
{
	/// <summary>
	/// <para>A list of loans to register.</para>
	/// </summary>
	[JsonPropertyName("loans")]
	public IReadOnlyList<Entity.CraLoanRegister> Loans { get; set; } = default!;

}

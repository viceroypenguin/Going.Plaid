namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraLoansApplicationsRegisterRequest defines the request schema for <c>/cra/loans/applications/register</c>.</para>
/// </summary>
public partial class CraLoansApplicationsRegisterRequest : RequestBase
{
	/// <summary>
	/// <para>A list of loan applications to register.</para>
	/// </summary>
	[JsonPropertyName("applications")]
	public IReadOnlyList<Entity.CraLoanApplication> Applications { get; set; } = default!;

}

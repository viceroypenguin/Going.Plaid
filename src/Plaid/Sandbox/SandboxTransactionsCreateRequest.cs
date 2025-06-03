namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxTransactionsCreateRequest defines the request schema for <c>/sandbox/transactions/create</c></para>
/// </summary>
public partial class SandboxTransactionsCreateRequest : RequestBase
{
	/// <summary>
	/// <para>List of transactions to be added</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.CustomSandboxTransaction> Transactions { get; set; } = default!;

}

namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorTokenPermissionsSetRequest defines the request schema for <c>/processor/token/permissions/set</c></para>
/// </summary>
public partial class ProcessorTokenPermissionsSetRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;

	/// <summary>
	/// <para>A list of products the processor token should have access to. An empty list will grant access to all products.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products> Products { get; set; } = default!;

}

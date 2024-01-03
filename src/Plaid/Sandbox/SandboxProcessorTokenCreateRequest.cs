namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxProcessorTokenCreateRequest defines the request schema for <c>/sandbox/processor_token/create</c></para>
/// </summary>
public partial class SandboxProcessorTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the institution the Item will be associated with</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; set; } = default!;

	/// <summary>
	/// <para>An optional set of options to be used when configuring the Item. If specified, must not be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.SandboxProcessorTokenCreateRequestOptions? Options { get; set; } = default!;

}

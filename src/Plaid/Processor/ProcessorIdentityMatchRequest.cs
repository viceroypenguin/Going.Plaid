namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorIdentityMatchRequest defines the request schema for <c>/processor/identity/match</c></para>
/// </summary>
public partial class ProcessorIdentityMatchRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;

	/// <summary>
	/// <para>The user's legal name, phone number, email address and address used to perform fuzzy match. If Financial Account Matching is enabled in the Identity Verification product, leave this field empty to automatically match against PII collected from the Identity Verification checks.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.IdentityMatchUser? User { get; set; } = default!;

}

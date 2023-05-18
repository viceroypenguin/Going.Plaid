namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorIdentityMatchResponse defines the response schema for <c>/processor/identity/match</c></para>
/// </summary>
public record ProcessorIdentityMatchResponse : ResponseBase
{
	/// <summary>
	/// <para>Identity match scores for an account</para>
	/// </summary>
	[JsonPropertyName("account")]
	public Entity.AccountIdentityMatchScore Account { get; init; } = default!;
}
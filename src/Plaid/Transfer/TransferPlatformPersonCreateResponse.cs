namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/platform/person/create</c></para>
/// </summary>
public record TransferPlatformPersonCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>An ID that should be used when submitting additional requirements that are associated with this person.</para>
	/// </summary>
	[JsonPropertyName("person_id")]
	public string PersonId { get; init; } = default!;

}

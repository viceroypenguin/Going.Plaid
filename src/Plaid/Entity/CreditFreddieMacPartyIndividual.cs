namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record CreditFreddieMacPartyIndividual
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("NAME")]
	public Entity.CreditFreddieMacIndividualName Name { get; init; } = default!;

}

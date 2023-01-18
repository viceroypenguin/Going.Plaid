namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record CreditFreddieMacPartyIndividual_VOA_2_4
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("NAME")]
	public Entity.CreditFreddieMacIndividualName_VOA_2_4 Name { get; init; } = default!;
}
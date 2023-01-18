namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record RoleDetail
{
	/// <summary>
	/// <para>A value from a MISMO defined list that identifies the role that the party plays in the transaction. Parties may be either a person or legal entity. A party may play multiple roles in a transaction.A value from a MISMO defined list that identifies the role that the party plays in the transaction. Parties may be either a person or legal entity. A party may play multiple roles in a transaction.</para>
	/// </summary>
	[JsonPropertyName("PartyRoleType")]
	public Entity.PartyRoleType Partyroletype { get; init; } = default!;
}
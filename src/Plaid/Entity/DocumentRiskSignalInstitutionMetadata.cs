namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object which contains additional metadata about the institution used to compute the verification attribute</para>
/// </summary>
public record DocumentRiskSignalInstitutionMetadata
{
	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;
}
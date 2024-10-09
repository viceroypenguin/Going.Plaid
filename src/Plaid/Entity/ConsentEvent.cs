namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes a consent event.</para>
/// </summary>
public record ConsentEvent
{
	/// <summary>
	/// <para>The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The date and time when the consent event occurred, in <a href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset? CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>A broad categorization of the consent event.</para>
	/// </summary>
	[JsonPropertyName("event_type")]
	public Entity.ConsentEventType? EventType { get; init; } = default!;

	/// <summary>
	/// <para>Codes describing the object of a consent event.</para>
	/// </summary>
	[JsonPropertyName("event_code")]
	public Entity.ConsentEventCode? EventCode { get; init; } = default!;

	/// <summary>
	/// <para>Unique identifier for the institution associated with the Item. Field is <c>null</c> for Items created via Same Day Micro-deposits.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The full name of the institution associated with the Item. Field is <c>null</c> for Items created via Same Day Micro-deposits.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string? InstitutionName { get; init; } = default!;

	/// <summary>
	/// <para>The entity that initiated collection of consent.</para>
	/// </summary>
	[JsonPropertyName("initiator")]
	public Entity.ConsentEventInitiator? Initiator { get; init; } = default!;

	/// <summary>
	/// <para>A list of strings containing the full list of use cases the end user has consented to for the Item.</para>
	/// <para>See the <a href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide/#updating-link-customizations">full list</a> of use cases.</para>
	/// </summary>
	[JsonPropertyName("consented_use_cases")]
	public IReadOnlyList<string>? ConsentedUseCases { get; init; } = default!;

	/// <summary>
	/// <para>A list of strings containing the full list of data scopes the end user has consented to for the Item. These correspond to consented products; see the <a href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide/#data-scopes-by-product">full mapping</a> of data scopes and products.</para>
	/// </summary>
	[JsonPropertyName("consented_data_scopes")]
	public IReadOnlyList<string>? ConsentedDataScopes { get; init; } = default!;

	/// <summary>
	/// <para>An array containing the accounts associated with the Item for which authorizations are granted.</para>
	/// </summary>
	[JsonPropertyName("consented_accounts")]
	public IReadOnlyList<Entity.ConsentedAccount>? ConsentedAccounts { get; init; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>A representation of an Item within an Asset Report.</para>
/// </summary>
public record AssetReportItem
{
	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The full financial institution name associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string InstitutionName { get; init; } = default!;

	/// <summary>
	/// <para>The id of the financial institution associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The date and time when this Item’s data was last retrieved from the financial institution, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("date_last_updated")]
	public DateTimeOffset DateLastUpdated { get; init; } = default!;

	/// <summary>
	/// <para>Data about each of the accounts open on the Item.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.AccountAssets> Accounts { get; init; } = default!;

}

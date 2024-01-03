namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing information about the payroll item.</para>
/// </summary>
public record PayrollItem
{
	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The unique identifier of the institution associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the institution associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string InstitutionName { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.PayrollIncomeAccountData> Accounts { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("payroll_income")]
	public IReadOnlyList<Entity.PayrollIncomeObject> PayrollIncome { get; init; } = default!;

	/// <summary>
	/// <para>Details about the status of the payroll item.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PayrollItemStatus? Status { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DDTHH:mm:ssZ) indicating the last time that the Item was updated.</para>
	/// </summary>
	[JsonPropertyName("updated_at")]
	public DateTimeOffset? UpdatedAt { get; init; } = default!;

}

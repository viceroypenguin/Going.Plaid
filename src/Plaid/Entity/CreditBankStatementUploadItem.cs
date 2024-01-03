namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing information about the bank statement upload Item.</para>
/// </summary>
public record CreditBankStatementUploadItem
{
	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("bank_statements")]
	public IReadOnlyList<Entity.CreditBankStatementUploadObject> BankStatements { get; init; } = default!;

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

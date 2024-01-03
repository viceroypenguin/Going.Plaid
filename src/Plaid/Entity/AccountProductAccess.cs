namespace Going.Plaid.Entity;

/// <summary>
/// <para>Allow the application to access specific products on this account</para>
/// </summary>
public record AccountProductAccess
{
	/// <summary>
	/// <para>Allow the application to access account data. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("account_data")]
	public bool? AccountData { get; init; } = default!;

	/// <summary>
	/// <para>Allow the application to access bank statements. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("statements")]
	public bool? Statements { get; init; } = default!;

	/// <summary>
	/// <para>Allow the application to access tax documents. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("tax_documents")]
	public bool? TaxDocuments { get; init; } = default!;

}

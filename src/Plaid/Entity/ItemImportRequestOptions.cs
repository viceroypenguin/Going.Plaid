namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to configure <c>/item/import</c> request.</para>
/// </summary>
public class ItemImportRequestOptions
{
	/// <summary>
	/// <para>Specifies a webhook URL to associate with an Item. Plaid fires a webhook if credentials fail.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;
}
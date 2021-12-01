namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Transfer product.</para>
/// </summary>
public class LinkTokenCreateRequestTransfer
{
	/// <summary>
	/// <para>The <c>id</c> returned by the <c>/transfer/intent/create</c> endpoint.</para>
	/// </summary>
	[JsonPropertyName("intent_id")]
	public string IntentId { get; set; } = default!;
}
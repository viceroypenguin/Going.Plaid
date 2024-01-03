namespace Going.Plaid.WebhookVerificationKey;

/// <summary>
/// <para>WebhookVerificationKeyGetRequest defines the request schema for <c>/webhook_verification_key/get</c></para>
/// </summary>
public partial class WebhookVerificationKeyGetRequest : RequestBase
{
	/// <summary>
	/// <para>The key ID ( <c>kid</c> ) from the JWT header.</para>
	/// </summary>
	[JsonPropertyName("key_id")]
	public string KeyId { get; set; } = default!;

}

namespace Going.Plaid.WebhookVerificationKey;

/// <summary>
/// <para>WebhookVerificationKeyGetResponse defines the response schema for <c>/webhook_verification_key/get</c></para>
/// </summary>
public record WebhookVerificationKeyGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A JSON Web Key (JWK) that can be used in conjunction with <a href="https://jwt.io/#libraries-io">JWT libraries</a> to verify Plaid webhooks</para>
	/// </summary>
	[JsonPropertyName("key")]
	public Entity.JWKPublicKey Key { get; init; } = default!;

}

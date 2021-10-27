namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Plaid signs all outgoing webhooks and provides JSON Web Tokens (JWTs) so that you can verify the authenticity of any incoming webhooks to your application. A message signature is included in the <c>Plaid-Verification</c> header.</para>
	/// <para>The <c>/webhook_verification_key/get</c> endpoint provides a JSON Web Key (JWK) that can be used to verify a JWT.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/webhooks/webhook-verification/#webhook_verification_keyget" /></remarks>
	public Task<WebhookVerificationKey.WebhookVerificationKeyGetResponse> WebhookVerificationKeyGetAsync(WebhookVerificationKey.WebhookVerificationKeyGetRequest request) =>
		PostAsync("/webhook_verification_key/get", request)
			.ParseResponseAsync<WebhookVerificationKey.WebhookVerificationKeyGetResponse>();
}
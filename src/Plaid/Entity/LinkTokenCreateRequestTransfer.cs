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
	public string? IntentId { get; set; } = default!;

	/// <summary>
	/// <para>The <c>id</c> returned by the <c>/transfer/authorization/create</c> endpoint. Used to indicate Link session to complete required user action in order to make a decision for the authorization. If set, <c>access_token</c> can be omitted.</para>
	/// </summary>
	[JsonPropertyName("authorization_id")]
	public string? AuthorizationId { get; set; } = default!;

	/// <summary>
	/// <para>The <c>payment_profile_token</c> returned by the <c>/payment_profile/create</c> endpoint.</para>
	/// </summary>
	[JsonPropertyName("payment_profile_token")]
	public string? PaymentProfileToken { get; set; } = default!;

}

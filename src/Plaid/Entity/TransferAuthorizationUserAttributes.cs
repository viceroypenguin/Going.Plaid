namespace Going.Plaid.Entity;

/// <summary>
/// <para>Typed attributes of the end user that Plaid models directly in transfer authorization decisioning. Use <c>custom_attributes</c> for any other risk-relevant context.</para>
/// </summary>
public class TransferAuthorizationUserAttributes
{
	/// <summary>
	/// <para>The date and time the end user created their account on your platform, in ISO 8601 format (<c>YYYY-MM-DDTHH:mm:ssZ</c>). This is the user's account with you, not a Plaid <c>account_id</c>.</para>
	/// </summary>
	[JsonPropertyName("account_created_time")]
	public DateTimeOffset? AccountCreatedTime { get; set; } = default!;

	/// <summary>
	/// <para>The total number of payments the end user has successfully completed on your platform since their account was created, across all payment methods. Excludes the payment being authorized, and excludes payments that were returned, charged back, or subsequently failed.</para>
	/// </summary>
	[JsonPropertyName("successful_payment_count")]
	public int? SuccessfulPaymentCount { get; set; } = default!;

}

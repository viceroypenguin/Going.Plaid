namespace Going.Plaid.Entity;

/// <summary>
/// <para>Life span for the payment consent. After the <c>to</c> date the payment consent expires and can no longer be used for payment initiation.</para>
/// </summary>
public class PaymentConsentValidDateTime
{
	/// <summary>
	/// <para>The date and time from which the consent should be active, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("from")]
	public DateTimeOffset? From { get; set; } = default!;

	/// <summary>
	/// <para>The date and time at which the consent expires, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("to")]
	public DateTimeOffset? To { get; set; } = default!;

}

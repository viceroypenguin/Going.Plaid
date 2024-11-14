namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Pay By Bank flow. This is an optional field to configure the user experience, and currently requires the amount field to be set.</para>
/// </summary>
public class LinkTokenCreateRequestPaymentConfiguration
{
	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; set; } = default!;

	/// <summary>
	/// <para>The description of the transfer that provides the payment context. The max length is 256.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; set; } = default!;

}

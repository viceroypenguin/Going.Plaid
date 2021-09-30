namespace Going.Plaid.Entity;

/// <summary>
/// <para>The legal name and other information for the account holder.</para>
/// </summary>
public class BankTransferUser
{
	/// <summary>
	/// <para>The account holder’s full legal name. If the transfer description is <c>ccd</c>, this should be the business name of the account holder.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string LegalName { get; set; } = default!;

	/// <summary>
	/// <para>The account holder’s email.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; set; } = default!;

	/// <summary>
	/// <para>The account holder's routing number. This field is only used in response data. Do not provide this field when making requests.</para>
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string RoutingNumber { get; set; } = default!;
}
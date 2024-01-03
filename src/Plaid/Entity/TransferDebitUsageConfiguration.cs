namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies the originator's expected usage of debits. For all dollar amounts, use a decimal string with two digits of precision e.g. "10.00". This field is required if the originator is expected to process debit transfers.</para>
/// </summary>
public class TransferDebitUsageConfiguration
{
	/// <summary>
	/// <para>The originator's expected transfer frequency.</para>
	/// </summary>
	[JsonPropertyName("expected_frequency")]
	public Entity.OriginatorExpectedTransferFrequency ExpectedFrequency { get; set; } = default!;

	/// <summary>
	/// <para>The originator’s expected highest amount for a single debit transfer.</para>
	/// </summary>
	[JsonPropertyName("expected_highest_amount")]
	public string ExpectedHighestAmount { get; set; } = default!;

	/// <summary>
	/// <para>The originator’s expected average amount per debit.</para>
	/// </summary>
	[JsonPropertyName("expected_average_amount")]
	public string ExpectedAverageAmount { get; set; } = default!;

	/// <summary>
	/// <para>The originator’s monthly expected ACH debit processing amount for the next 6-12 months.</para>
	/// </summary>
	[JsonPropertyName("expected_monthly_amount")]
	public string ExpectedMonthlyAmount { get; set; } = default!;

	/// <summary>
	/// <para>Specifies the expected use cases for the originator’s debit transfers. This should be a list that contains one or more of the following codes:</para>
	/// <para><c>"ccd"</c> - Corporate Credit or Debit - fund transfer between two corporate bank accounts</para>
	/// <para><c>"ppd"</c> - Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, eg. bill payment</para>
	/// <para><c>"tel"</c> - Telephone-Initiated Entry</para>
	/// <para><c>"web"</c> - Internet-Initiated Entry - debits from a consumer’s account where their authorization is obtained over the Internet</para>
	/// </summary>
	[JsonPropertyName("sec_codes")]
	public IReadOnlyList<Entity.AchClass> SecCodes { get; set; } = default!;

}

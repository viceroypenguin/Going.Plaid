namespace Going.Plaid.Entity;

/// <summary>
/// <para>The diligence information for the originator.</para>
/// </summary>
public class TransferOriginatorDiligence
{
	/// <summary>
	/// <para>The business name of the originator.</para>
	/// </summary>
	[JsonPropertyName("dba")]
	public string Dba { get; set; } = default!;

	/// <summary>
	/// <para>The tax ID of the originator.</para>
	/// </summary>
	[JsonPropertyName("tax_id")]
	public string TaxId { get; set; } = default!;

	/// <summary>
	/// <para>Specifies the originator's expected usage of credits. For all dollar amounts, use a decimal string with two digits of precision e.g. "10.00". This field is required if the originator is expected to process credit transfers.</para>
	/// </summary>
	[JsonPropertyName("credit_usage_configuration")]
	public Entity.TransferCreditUsageConfiguration? CreditUsageConfiguration { get; set; } = default!;

	/// <summary>
	/// <para>Specifies the originator's expected usage of debits. For all dollar amounts, use a decimal string with two digits of precision e.g. "10.00". This field is required if the originator is expected to process debit transfers.</para>
	/// </summary>
	[JsonPropertyName("debit_usage_configuration")]
	public Entity.TransferDebitUsageConfiguration? DebitUsageConfiguration { get; set; } = default!;

	/// <summary>
	/// <para>The originator's address.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.TransferOriginatorAddress Address { get; set; } = default!;

	/// <summary>
	/// <para>The website of the originator.</para>
	/// </summary>
	[JsonPropertyName("website")]
	public string Website { get; set; } = default!;

	/// <summary>
	/// <para>The NAICS code of the originator.</para>
	/// </summary>
	[JsonPropertyName("naics_code")]
	public string NaicsCode { get; set; } = default!;

	/// <summary>
	/// <para>The originator's funding account, linked with Plaid Link or <c>/transfer/migrate_account</c>.</para>
	/// </summary>
	[JsonPropertyName("funding_account")]
	public Entity.TransferFundingAccount FundingAccount { get; set; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the payment consent payer details. </para>
/// <para>Payer <c>name</c> and account <c>numbers</c> are required to lock the account to which the consent can be created.</para>
/// </summary>
public class PaymentInitiationConsentPayerDetails
{
	/// <summary>
	/// <para>The name of the payer as it appears in their bank account</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = default!;

	/// <summary>
	/// <para>The counterparty's bank account numbers. Exactly one of IBAN or BACS data is required.</para>
	/// </summary>
	[JsonPropertyName("numbers")]
	public Entity.PaymentInitiationConsentPayerNumbers Numbers { get; set; } = default!;

	/// <summary>
	/// <para>The optional address of the payment recipient's bank account. Required by most institutions outside of the UK.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.PaymentInitiationAddress? Address { get; set; } = default!;

	/// <summary>
	/// <para>The payer's birthdate, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> (YYYY-MM-DD) format.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly? DateOfBirth { get; set; } = default!;

	/// <summary>
	/// <para>The payer's phone numbers in E.164 format: +{countrycode}{number}</para>
	/// </summary>
	[JsonPropertyName("phone_numbers")]
	public IReadOnlyList<string>? PhoneNumbers { get; set; } = default!;

	/// <summary>
	/// <para>The payer's emails</para>
	/// </summary>
	[JsonPropertyName("emails")]
	public IReadOnlyList<string>? Emails { get; set; } = default!;

}

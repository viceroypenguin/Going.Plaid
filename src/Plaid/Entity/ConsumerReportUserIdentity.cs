namespace Going.Plaid.Entity;

/// <summary>
/// <para>To create a Plaid Check Consumer Report for a user, this field must be present on the user token. If this field is not provided during user token creation, you can add it to the user later by calling <c>/user/update</c>. Once the field has been added to the user, you will be able to call <c>/link/token/create</c> with a non-empty <c>consumer_report_permissible_purpose</c> (which will automatically create a Plaid Check Consumer Report), or call <c>/cra/check_report/create</c> for that user.</para>
/// </summary>
public class ConsumerReportUserIdentity
{
	/// <summary>
	/// <para>The user's first name</para>
	/// </summary>
	[JsonPropertyName("first_name")]
	public string FirstName { get; set; } = default!;

	/// <summary>
	/// <para>The user's last name</para>
	/// </summary>
	[JsonPropertyName("last_name")]
	public string LastName { get; set; } = default!;

	/// <summary>
	/// <para>The user's phone number, in E.164 format: +{countrycode}{number}. For example: "+14157452130". Phone numbers provided in other formats will be parsed on a best-effort basis. Phone number input is validated against valid number ranges; number strings that do not match a real-world phone numbering scheme may cause the request to fail, even in the Sandbox test environment.</para>
	/// </summary>
	[JsonPropertyName("phone_numbers")]
	public IReadOnlyList<string> PhoneNumbers { get; set; } = default!;

	/// <summary>
	/// <para>The user's emails</para>
	/// </summary>
	[JsonPropertyName("emails")]
	public IReadOnlyList<string> Emails { get; set; } = default!;

	/// <summary>
	/// <para>The last 4 digits of the user's social security number.</para>
	/// </summary>
	[JsonPropertyName("ssn_last_4")]
	public string? SsnLast4 { get; set; } = default!;

	/// <summary>
	/// <para>To be provided in the format "yyyy-mm-dd".</para>
	/// <para>This field is required for all Plaid Check customers.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly? DateOfBirth { get; set; } = default!;

	/// <summary>
	/// <para>Data about the components comprising an address.</para>
	/// </summary>
	[JsonPropertyName("primary_address")]
	public Entity.AddressData PrimaryAddress { get; set; } = default!;

}

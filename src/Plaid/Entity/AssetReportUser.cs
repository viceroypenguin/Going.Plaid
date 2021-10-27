namespace Going.Plaid.Entity;

/// <summary>
/// <para>The user object allows you to provide additional information about the user to be appended to the Asset Report. All fields are optional. The <c>first_name</c>, <c>last_name</c>, and <c>ssn</c> fields are required if you would like the Report to be eligible for Fannie Mae’s Day 1 Certainty™ program.</para>
/// </summary>
public class AssetReportUser
{
	/// <summary>
	/// <para>An identifier you determine and submit for the user.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>The user's first name. Required for the Fannie Mae Day 1 Certainty™ program.</para>
	/// </summary>
	[JsonPropertyName("first_name")]
	public string? FirstName { get; set; } = default!;

	/// <summary>
	/// <para>The user's middle name</para>
	/// </summary>
	[JsonPropertyName("middle_name")]
	public string? MiddleName { get; set; } = default!;

	/// <summary>
	/// <para>The user's last name.  Required for the Fannie Mae Day 1 Certainty™ program.</para>
	/// </summary>
	[JsonPropertyName("last_name")]
	public string? LastName { get; set; } = default!;

	/// <summary>
	/// <para>The user's Social Security Number. Required for the Fannie Mae Day 1 Certainty™ program.</para>
	/// <para>Format: "ddd-dd-dddd"</para>
	/// </summary>
	[JsonPropertyName("ssn")]
	public string? Ssn { get; set; } = default!;

	/// <summary>
	/// <para>The user's phone number, in E.164 format: +{countrycode}{number}. For example: "+14151234567". Phone numbers provided in other formats will be parsed on a best-effort basis.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; set; } = default!;

	/// <summary>
	/// <para>The user's email address.</para>
	/// </summary>
	[JsonPropertyName("email")]
	public string? Email { get; set; } = default!;
}
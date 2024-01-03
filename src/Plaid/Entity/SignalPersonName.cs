namespace Going.Plaid.Entity;

/// <summary>
/// <para>The user's legal name</para>
/// </summary>
public class SignalPersonName
{
	/// <summary>
	/// <para>The user's name prefix (e.g. "Mr.")</para>
	/// </summary>
	[JsonPropertyName("prefix")]
	public string? Prefix { get; set; } = default!;

	/// <summary>
	/// <para>The user's given name. If the user has a one-word name, it should be provided in this field.</para>
	/// </summary>
	[JsonPropertyName("given_name")]
	public string? GivenName { get; set; } = default!;

	/// <summary>
	/// <para>The user's middle name</para>
	/// </summary>
	[JsonPropertyName("middle_name")]
	public string? MiddleName { get; set; } = default!;

	/// <summary>
	/// <para>The user's family name / surname</para>
	/// </summary>
	[JsonPropertyName("family_name")]
	public string? FamilyName { get; set; } = default!;

	/// <summary>
	/// <para>The user's name suffix (e.g. "II")</para>
	/// </summary>
	[JsonPropertyName("suffix")]
	public string? Suffix { get; set; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>Email address associated with a business</para>
/// </summary>
public record BusinessEmailAddress
{
	/// <summary>
	/// <para>Email address of the business</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string EmailAddress { get; init; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>Phone number associated with a business</para>
/// </summary>
public record BusinessPhoneNumber
{
	/// <summary>
	/// <para>Phone number in E.164 format</para>
	/// </summary>
	[JsonPropertyName("number")]
	public string? Number { get; init; } = default!;

}

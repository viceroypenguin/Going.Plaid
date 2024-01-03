namespace Going.Plaid.Entity;

/// <summary>
/// <para>A phone number</para>
/// </summary>
public record PhoneNumber
{
	/// <summary>
	/// <para>The phone number.</para>
	/// </summary>
	[JsonPropertyName("data")]
	public string Data { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, identifies the phone number as the primary number on an account.</para>
	/// </summary>
	[JsonPropertyName("primary")]
	public bool Primary { get; init; } = default!;

	/// <summary>
	/// <para>The type of phone number.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.PhoneNumberTypeEnum Type { get; init; } = default!;

}

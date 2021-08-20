namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an email address</para>
/// </summary>
public record Email
{
	/// <summary>
	/// <para>The email address.</para>
	/// </summary>
	[JsonPropertyName("data")]
	public string Data { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, identifies the email address as the primary email on an account.</para>
	/// </summary>
	[JsonPropertyName("primary")]
	public bool Primary { get; init; } = default!;

	/// <summary>
	/// <para>The type of email account as described by the financial institution.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.EmailTypeEnum Type { get; init; } = default!;
}
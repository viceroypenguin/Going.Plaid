namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data on the W2 Box 12</para>
/// </summary>
public record W2Box12
{
	/// <summary>
	/// <para>W2 Box 12 code.</para>
	/// </summary>
	[JsonPropertyName("code")]
	public string? Code { get; init; } = default!;

	/// <summary>
	/// <para>W2 Box 12 amount.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string? Amount { get; init; } = default!;

}

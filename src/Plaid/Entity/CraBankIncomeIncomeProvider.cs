namespace Going.Plaid.Entity;

/// <summary>
/// <para>The object containing data about the income provider.</para>
/// </summary>
public record CraBankIncomeIncomeProvider
{
	/// <summary>
	/// <para>The name of the income provider.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the income provider name is normalized by comparing it against a canonical set of known providers.</para>
	/// </summary>
	[JsonPropertyName("is_normalized")]
	public bool IsNormalized { get; init; } = default!;

}

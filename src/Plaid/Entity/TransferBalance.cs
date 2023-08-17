namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the balance held with Plaid.</para>
/// </summary>
public record TransferBalance
{
	/// <summary>
	/// <para>The amount of this balance available for use (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("available")]
	public string Available { get; init; } = default!;

	/// <summary>
	/// <para>The available balance, plus amount of pending funds that in processing (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("current")]
	public string? Current { get; init; } = default!;

	/// <summary>
	/// <para>The type of balance.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.TransferBalanceType Type { get; init; } = default!;
}
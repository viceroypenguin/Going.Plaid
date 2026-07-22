namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional details for receiver events. Currently always <c>null</c>.</para>
/// </summary>
public record ReceiverDetails
{
	/// <summary>
	/// <para>The available balance associated with the receiver event.</para>
	/// </summary>
	[JsonPropertyName("available_balance")]
	public string? AvailableBalance { get; init; } = default!;

}

namespace Going.Plaid.Entity;

/// <summary>
/// <para>Conveys information about the errors causing missing or stale bank data used to construct the /signal/evaluate scores and response</para>
/// </summary>
public record SignalWarning
{
	/// <summary>
	/// <para>Broad categorization of the warning.</para>
	/// </summary>
	[JsonPropertyName("warning_type")]
	public string WarningType { get; init; } = default!;

	/// <summary>
	/// <para>The particular warning code.</para>
	/// </summary>
	[JsonPropertyName("warning_code")]
	public string WarningCode { get; init; } = default!;

	/// <summary>
	/// <para>A developer-friendly representation of the warning code.</para>
	/// </summary>
	[JsonPropertyName("warning_message")]
	public string WarningMessage { get; init; } = default!;
}
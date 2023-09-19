namespace Going.Plaid.Entity;

/// <summary>
/// <para>Conveys information about the errors causing missing or stale bank data used to construct the /signal/evaluate scores and response</para>
/// </summary>
public record SignalWarning
{
	/// <summary>
	/// <para>A broad categorization of the warning. Safe for programmatic use.</para>
	/// </summary>
	[JsonPropertyName("warning_type")]
	public string? WarningType { get; init; } = default!;

	/// <summary>
	/// <para>The warning code identifies a specific kind of warning that pertains to the error causing bank data to be missing. Safe for programmatic use. For more details on warning codes, please refer to Plaid standard error codes documentation. If you receive the <c>ITEM_LOGIN_REQUIRED</c> warning, we recommend re-authenticating your user by implementing Link's update mode. This will guide your user to fix their credentials, allowing Plaid to start fetching data again for future Signal requests.</para>
	/// </summary>
	[JsonPropertyName("warning_code")]
	public string? WarningCode { get; init; } = default!;

	/// <summary>
	/// <para>A developer-friendly representation of the warning type. This may change over time and is not safe for programmatic use.</para>
	/// </summary>
	[JsonPropertyName("warning_message")]
	public string? WarningMessage { get; init; } = default!;
}
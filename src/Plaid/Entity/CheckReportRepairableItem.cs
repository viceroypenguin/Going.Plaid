namespace Going.Plaid.Entity;

/// <summary>
/// <para>An error object plus the <c>item_id</c> of an Item that the end user can repair via Link <a href="https://plaid.com/docs/link/update-mode">update mode</a>. The <c>error_code</c> will be in the <c>ITEM_LOGIN_REQUIRED</c> family.</para>
/// </summary>
public record CheckReportRepairableItem
{
	/// <summary>
	/// <para>A broad categorization of the error. Safe for programmatic use.</para>
	/// </summary>
	[JsonPropertyName("error_type")]
	public Entity.PlaidErrorType ErrorType { get; init; } = default!;

	/// <summary>
	/// <para>The particular error code. Safe for programmatic use.</para>
	/// </summary>
	[JsonPropertyName("error_code")]
	public string ErrorCode { get; init; } = default!;

	/// <summary>
	/// <para>A developer-friendly representation of the error code. This may change over time and is not safe for programmatic use.</para>
	/// </summary>
	[JsonPropertyName("error_message")]
	public string ErrorMessage { get; init; } = default!;

	/// <summary>
	/// <para>A user-friendly representation of the error code. <c>null</c> if the error is not related to user action.</para>
	/// </summary>
	[JsonPropertyName("display_message")]
	public string? DisplayMessage { get; init; } = default!;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

}

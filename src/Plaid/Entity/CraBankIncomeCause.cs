namespace Going.Plaid.Entity;

/// <summary>
/// <para>An error object and associated <c>item_id</c> used to identify a specific Item and error when a batch operation operating on multiple Items has encountered an error in one of the Items.</para>
/// </summary>
public record CraBankIncomeCause
{
	/// <summary>
	/// <para>A broad categorization of the error. Safe for programmatic use.</para>
	/// </summary>
	[JsonPropertyName("error_type")]
	public Entity.CreditBankIncomeErrorType ErrorType { get; init; } = default!;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. Error fields will be <c>null</c> if no error has occurred.</para>
	/// </summary>
	[JsonPropertyName("error_code")]
	public string ErrorCode { get; init; } = default!;

	/// <summary>
	/// <para>A developer-friendly representation of the error code. This may change over time and is not safe for programmatic use.</para>
	/// </summary>
	[JsonPropertyName("error_message")]
	public string ErrorMessage { get; init; } = default!;

	/// <summary>
	/// <para>A user-friendly representation of the error code. null if the error is not related to user action.</para>
	/// <para>This may change over time and is not safe for programmatic use.</para>
	/// </summary>
	[JsonPropertyName("display_message")]
	public string DisplayMessage { get; init; } = default!;
}
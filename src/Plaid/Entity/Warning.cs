namespace Going.Plaid.Entity;

/// <summary>
/// <para>It is possible for an Asset Report to be returned with missing account owner information. In such cases, the Asset Report will contain warning data in the response, indicating why obtaining the owner information failed.</para>
/// </summary>
public record Warning
{
	/// <summary>
	/// <para>The warning type, which will always be <c>ASSET_REPORT_WARNING</c></para>
	/// </summary>
	[JsonPropertyName("warning_type")]
	public string WarningType { get; init; } = default!;

	/// <summary>
	/// <para>The warning code identifies a specific kind of warning. <c>OWNERS_UNAVAILABLE</c> indicates that account-owner information is not available.<c>INVESTMENTS_UNAVAILABLE</c> indicates that Investments specific information is not available. <c>TRANSACTIONS_UNAVAILABLE</c> indicates that transactions information associated with Credit and Depository accounts are unavailable.</para>
	/// </summary>
	[JsonPropertyName("warning_code")]
	public Entity.WarningWarningCodeEnum WarningCode { get; init; } = default!;

	/// <summary>
	/// <para>An error object and associated <c>item_id</c> used to identify a specific Item and error when a batch operation operating on multiple Items has encountered an error in one of the Items.</para>
	/// </summary>
	[JsonPropertyName("cause")]
	public Entity.Cause Cause { get; init; } = default!;

}

namespace Going.Plaid.User;

/// <summary>
/// <para>UserFinancialDataRefreshRequest defines the request schema for <c>user/financial_data/refresh</c></para>
/// </summary>
public partial class UserFinancialDataRefreshRequest : RequestBase
{
	/// <summary>
	/// <para>A Plaid-generated ID that identifies the end user.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

}

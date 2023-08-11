namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraBankIncomeGetRequest defines the request schema for <c>/cra/bank_income/get</c>.</para>
/// </summary>
public partial class CraBankIncomeGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;
}
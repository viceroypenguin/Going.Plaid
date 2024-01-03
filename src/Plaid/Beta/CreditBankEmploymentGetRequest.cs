namespace Going.Plaid.Beta;

/// <summary>
/// <para>CreditBankEmploymentGetRequest defines the request schema for <c>/beta/credit/v1/bank_employment/get</c>.</para>
/// </summary>
public partial class CreditBankEmploymentGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

}

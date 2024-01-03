namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditEmploymentGetRequest defines the request schema for <c>/credit/employment/get</c>.</para>
/// </summary>
public partial class CreditEmploymentGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

}

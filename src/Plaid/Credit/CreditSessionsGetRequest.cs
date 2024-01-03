namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditSessionsGetRequest defines the request schema for <c>/credit/sessions/get</c></para>
/// </summary>
public partial class CreditSessionsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

}

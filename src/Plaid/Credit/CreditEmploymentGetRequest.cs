namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditEmploymentGetRequest defines the request schema for <c>/credit/employment/get</c>.</para>
/// </summary>
public partial class CreditEmploymentGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

}
